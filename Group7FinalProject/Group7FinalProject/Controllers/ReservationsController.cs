using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group7FinalProject.DAL;
using Group7FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data.Common;
using Microsoft.AspNetCore.Identity;

namespace Group7FinalProject.Controllers
    
{

    public class ReservationsController : Controller
    {

        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;


        public ReservationsController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            // Set up a list of reservations to display
            List<Reservation> reservations;

            // Check user role and filter reservations accordingly
            if (User.IsInRole("Host"))
            {
                reservations = _context.Reservations
                                .Include(r => r.Property)
                                .Where(r => r.Property.User.UserName == User.Identity.Name)
                                .Where(r => r.ReservationStatus == ReservationStatus.Valid || r.ReservationStatus == ReservationStatus.Cancelled)
                                .ToList();
            }
            else
            {
                // User is a customer, so only display their records
                reservations = _context.Reservations
                                .Include(r => r.Property)
                                .Where(r => r.User.UserName == User.Identity.Name)
                                .Where(r => r.ReservationStatus == ReservationStatus.Valid || r.ReservationStatus == ReservationStatus.Cancelled)
                                .ToList();
            }

            // Check if the reservations list is empty
            if (reservations == null || !reservations.Any())
            {
                // Return a view with a message indicating no reservations
                ViewBag.Message = "You have not made any reservations yet. Please browse our properties and make a reservation to see it here.";
                return View("NoReservations");
            }

            // Return the list of reservations if there are any
            return View(reservations);
        }


        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //the user did not specify a reservation to view
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a reservation to view!" });
            }

            //find the reservation in the database
            Reservation reservation = await _context.Reservations
                                              .Include(r => r.Property)
                                              .Include(r => r.User)
                                              .FirstOrDefaultAsync(m => m.ReservationID == id);

            //reservation was not found in the database
            if (reservation == null)
            {
                return View("Error", new String[] { "This reservation was not found!" });
            }

            //make sure this order belongs to this user
            if (User.IsInRole("Customer") && reservation.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your reservation!  Don't be such a snoop!" });
            }

            reservation.CalcTotals();

            //Send the user to the details page
            return View(reservation);
        }

        [Authorize(Roles = "Customer,Admin")]

        public async Task<IActionResult> Create(int? PropertyID)
        {

            if (PropertyID == null)
            {
                return View("Error", new string[] { "Please specify a property to add to the reservation" });
            }

            //find the property in the database
            Property dbProperty = _context.Properties.Find(PropertyID);

            //make sure the Property exists in the database
            if (dbProperty == null)
            {
                return View("Error", new string[] { "This Property was not in the database!" });
            }

            if (User.IsInRole("Admin"))
            {
                ViewBag.UserNames = await GetAllCustomerUserNamesSelectList();
                return View("SelectCustomerForReservation", new Reservation { Property = dbProperty });
            }

            Reservation res = new Reservation();
            res.Property = dbProperty;
            res.CheckIn = DateTime.Today.AddDays(1); // Default check-in
            res.CheckOut = DateTime.Today.AddDays(2); // Default check-out
            res.User = await _userManager.FindByNameAsync(User.Identity.Name);


            return View(res);

        }





        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Customer,Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reservation reservation, int propertyID, string? SelectedCustomer)
        {


            if (ModelState.IsValid == false)
            {
                return View(reservation);
            }

            //find the property to be associated with this reservation
            Property dbProperty = _context.Properties.Find(propertyID);

            reservation.Property = dbProperty;

            if (dbProperty == null)
            {
                return View("Error", new string[] { "The property could not be found." });
            }

            // Validate the number of guests against the property's guest limit
            if (reservation.NumOfGuests > dbProperty.GuestsAllowed)
            {
                return View("Error", new string[] { $"The number of guests exceeds the property's limit of {dbProperty.GuestsAllowed}." });
            }

            // Load the User
            if (User.IsInRole("Customer"))
            {
                reservation.User = await _userManager.FindByNameAsync(User.Identity.Name);
                if (reservation.User == null)
                {
                    return View("Error", new string[] { "The user could not be found." });
                }

            }
            //If user is an admin, make reservation user the parameter
            if (User.IsInRole("Admin"))
            {
                reservation.User = await _userManager.FindByNameAsync(SelectedCustomer);
                if (reservation.User == null)
                {
                    return View("Error", new string[] { "The user could not be found." });
                }
            }

            // Validate CheckIn and CheckOut dates
            if (reservation.CheckIn <= DateTime.Today)
            {
                return View("Error", new string[] { "Check-in date must be in the future." });
            }

            if (reservation.CheckOut <= reservation.CheckIn)
            {
                return View("Error", new string[] { "Check-out date must be after the check-in date." });
            }

            // Retrieve reservations for the specified property
            List<Reservation> reservations = await _context.Reservations
                .Include(r => r.Property)
                .Where(r => r.Property.PropertyID == propertyID)
                .ToListAsync();

            // Check for overlapping reservations
            if (reservations.Count(r =>
             (reservation.CheckIn >= r.CheckIn && reservation.CheckIn < r.CheckOut) || // Overlaps on check-in
             (reservation.CheckOut > r.CheckIn && reservation.CheckOut <= r.CheckOut) || // Overlaps on check-out
             (reservation.CheckIn <= r.CheckIn && reservation.CheckOut >= r.CheckOut)) > 0) // Completely overlaps
            {
                return View("Error", new string[] { "The reservation dates overlap with an existing reservation for this property." });
            }

            // Fetch reservations for the same user
            List<Reservation> userReservations = await _context.Reservations
                .Where(r => r.User.UserName == User.Identity.Name) // Match the current user
                .ToListAsync();

            // Check for overlapping reservations for the same user
            if (userReservations.Count(r =>
                (reservation.CheckIn >= r.CheckIn && reservation.CheckIn < r.CheckOut) || // Overlaps on check-in
                (reservation.CheckOut > r.CheckIn && reservation.CheckOut <= r.CheckOut) || // Overlaps on check-out
                (reservation.CheckIn <= r.CheckIn && reservation.CheckOut >= r.CheckOut)) > 0) // Completely overlaps
            {
                return View("Error", new string[] { "You already have a reservation during these dates." });
            }




            reservation.WeekdayPrice = dbProperty.WeekdayPrice;
            reservation.WeekendPrice = dbProperty.WeekendPrice;
            reservation.CleaningFee = dbProperty.CleaningFee;
            reservation.DiscountRate = dbProperty.DiscountRate;

            if (User.IsInRole("Customer"))
            {
                reservation.ReservationStatus = ReservationStatus.Unconfirmed;
            }
            if (User.IsInRole("Admin"))
            {
                reservation.ReservationStatus = ReservationStatus.Valid;
                reservation.ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(_context);

            }

            //if code gets this far, add the reservation to the database
            _context.Add(reservation);
            await _context.SaveChangesAsync();


            if (User.IsInRole("Customer"))
            {
                // Add the reservation to the cart
                Cart cart = await _context.Carts
                .FirstOrDefaultAsync(c => c.User.Id == reservation.User.Id);

                if (cart == null)
                {
                    // Create a new cart if the user doesn't have an active one
                    cart = new Cart
                    {
                        User = reservation.User,
                    };
                    _context.Carts.Add(cart);
                    await _context.SaveChangesAsync();
                }
                cart.Reservations.Add(reservation);
                _context.Carts.Update(cart);
                await _context.SaveChangesAsync();



                // Redirect to the cart page
                return RedirectToAction("Index", "Carts");
            }
            if (User.IsInRole("Admin"))
            {
                // Add dates to the Unavailabilities table
                for (DateTime date = reservation.CheckIn; date < reservation.CheckOut; date = date.AddDays(1))
                {
                    // Instantiate a new Unavailability object for each date
                    Unavailability unavailability = new Unavailability
                    {
                        UnavailableDate = date,
                        Property = reservation.Property
                    };

                    _context.Unavailabilities.Add(unavailability);
                }
                await _context.SaveChangesAsync();

                return RedirectToAction("Confirmation", new { confirmationNumber = reservation.ConfirmationNumber });
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }

        }

        public async Task<IActionResult> Confirmation(int confirmationNumber)
        {
            Reservation reservation = await _context.Reservations
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ConfirmationNumber == confirmationNumber);

            if (reservation == null)
            {
                return View("Error", new string[] { "No reservation found for this confirmation number." });
            }

            reservation.CalcTotals();

            ViewBag.ConfirmationNumber = confirmationNumber;

            return View(reservation);
        }


        [Authorize(Roles = "Customer,Host")]
        public async Task<IActionResult> CancelReservation(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a reservation to cancel!" });
            }

            // Find the reservation in the database
            Reservation reservation = await _context.Reservations
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ReservationID == id);

            if (reservation == null)
            {
                return View("Error", new string[] { "This reservation was not found!" });
            }

            if (reservation.CheckIn <= DateTime.Now.AddHours(24))
            {
                return View("Error", new string[] { "Reservations can only be canceled if the check-in date is more than 24 hours away." });
            }


            // Update the reservation status
            reservation.ReservationStatus = ReservationStatus.Cancelled;

            // Remove associated dates from the Unavailabilities table
            List<Unavailability> unavailabilities = await _context.Unavailabilities
                .Where(u => u.Property.PropertyID == reservation.Property.PropertyID &&
                            u.UnavailableDate >= reservation.CheckIn &&
                            u.UnavailableDate < reservation.CheckOut)
                .ToListAsync();

            _context.Unavailabilities.RemoveRange(unavailabilities);

            // Save the changes
            await _context.SaveChangesAsync();

            // Redirect to the reservations index
            return RedirectToAction(nameof(Index));
        }




        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ReservationID == id);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SelectCustomerForReservation(String SelectedCustomer, int? propertyID)
        {
            if (String.IsNullOrEmpty(SelectedCustomer))
            {
                ViewBag.UserNames = await GetAllCustomerUserNamesSelectList();

                return View("SelectCustomerForReservation");
            }


            if (propertyID == null)
            {
                return View("Error", new string[] { "Please specify a property to add to the reservation" });
            }

            //find the property in the database
            Property dbProperty = _context.Properties.Find(propertyID);

            //make sure the Property exists in the database
            if (dbProperty == null)
            {
                return View("Error", new string[] { "This Property was not in the database!" });
            }


            Reservation res = new Reservation();
            res.Property = dbProperty;
            res.CheckIn = DateTime.Today.AddDays(1); // Default check-in
            res.CheckOut = DateTime.Today.AddDays(2); // Default check-out
            res.User = await _userManager.FindByNameAsync(SelectedCustomer);
            if (res.User == null)
            {
                return View("Error", new string[] { "The selected customer could not be found." });
            }
            return View("Create", res);
        }

        public async Task<SelectList> GetAllCustomerUserNamesSelectList()
        {
            //create a list to hold the customers
            List<AppUser> allCustomers = new List<AppUser>();

            //See if the user is a customer
            foreach (AppUser dbUser in _context.Users)
            {
                //if the user is a customer, add them to the list of customers
                if (await _userManager.IsInRoleAsync(dbUser, "Customer") == true)//user is a customer
                {
                    allCustomers.Add(dbUser);
                }
            }

            //create a new select list with the customer emails
            SelectList sl = new SelectList(allCustomers.OrderBy(c => c.Email), nameof(AppUser.UserName), nameof(AppUser.Email));

            //return the select list
            return sl;

        }
    }
}
