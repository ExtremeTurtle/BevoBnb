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
            //Set up a list of reservations to display
            List<Reservation> reservations;

            //User.IsInRole -- they see ALL reservations and details for their property
            if (User.IsInRole("Host"))
            {
                reservations = _context.Reservations
                                .Include(r => r.Property)
                                .Where(r => r.Property.User.UserName == User.Identity.Name)
                                .ToList();
            }
            else //user is a customer, so only display their records
            //reservations is assocated with a particular user (look on the order model class)
            //every logged in user is allowed to access index page, but their results will be different
            {
                reservations = _context.Reservations
                                .Include(r => r.Property)
                                .Where(r => r.User.UserName == User.Identity.Name)
                                .ToList();
            }

            //
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

            // Calculate the total price dynamically
            int totalDays = (reservation.CheckOut - reservation.CheckIn).Days + 1; // Include the start date
            int weekdayCount = 0;
            int weekendCount = 0;

            // Determine the number of weekdays and weekends in the reservation
            for (DateTime date = reservation.CheckIn; date <= reservation.CheckOut; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekendCount++;
                }
                else
                {
                    weekdayCount++;
                }
            }

            // Calculate the base price
            decimal basePrice = (weekdayCount * reservation.WeekdayPrice) + (weekendCount * reservation.WeekendPrice);

            // Apply the discount if applicable
            decimal discount;
            if (totalDays >= reservation.Property.MinNightsForDiscount)
            {
                discount = basePrice * (reservation.Property.DiscountRate / 100); // Apply discount based on property rate
            }
            else
            {
                discount = 0;
            }


            // Calculate the final price including the cleaning fee
            decimal totalPrice = basePrice - discount + reservation.CleaningFee; // Subtract the discount, then add the cleaning fee

            // Pass the total price to the view using ViewBag
            ViewBag.TotalPrice = totalPrice;

            //Send the user to the details page
            return View(reservation);
        }

        [Authorize(Roles = "Customer,Admin")]

        public async Task <IActionResult> Create(int? PropertyID)
        {
            if (User.IsInRole("Customer"))
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


                Reservation res = new Reservation();
                res.Property = dbProperty;
                res.CheckIn = DateTime.Today.AddDays(1); // Default check-in
                res.CheckOut = DateTime.Today.AddDays(2); // Default check-out
                res.User = await _userManager.FindByNameAsync(User.Identity.Name);
                return View(res);
            }
            else
            {
                ViewBag.UserNames = await GetAllCustomerUserNamesSelectList();
                return View("SelectCustomerForReservation");
            }
        }


        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Customer,Admin")]
        [ValidateAntiForgeryToken]
           public async Task<IActionResult> Create(Reservation reservation, int propertyID)
        {
            if (!ModelState.IsValid)
            {
                return View(reservation);
            }

            //find the property to be associated with this reservation
            Property dbProperty = _context.Properties.Find(propertyID);

            reservation.Property= dbProperty;

            if (dbProperty == null)
            {
                return View("Error", new string[] { "The property could not be found." });
            }



            // Load the User
            reservation.User = await _userManager.FindByNameAsync(User.Identity.Name);
            if (reservation.User == null)
            {
                return View("Error", new string[] { "The user could not be found." });
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




            reservation.WeekdayPrice = dbProperty.WeekdayPrice;
            reservation.WeekendPrice = dbProperty.WeekendPrice;
            reservation.CleaningFee = dbProperty.CleaningFee;
            reservation.DiscountRate = dbProperty.DiscountRate;
            reservation.ReservationStatus = ReservationStatus.Unconfirmed;

            //if code gets this far, add the reservation to the database
            _context.Add(reservation);
            await _context.SaveChangesAsync();

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



        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservationID,ConfirmationNumber,CheckIn,CheckOut,NumOfGuests,WeekdayPrice,WeekendPrice,CleaningFee,DiscountRate,ReservationStatus")] Reservation reservation)
        {
            if (id != reservation.ReservationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.ReservationID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }

       

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ReservationID == id);
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
