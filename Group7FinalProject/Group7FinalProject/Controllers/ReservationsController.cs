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

        // GET: Reservations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Customer,Admin")]
        [ValidateAntiForgeryToken]
           public async Task<IActionResult> Create(Reservation reservation, int SelectedProperty)
        {
            if (!ModelState.IsValid)
            {
                return View(reservation);
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

            // Find the selected property
            var dbProperty = await _context.Properties.FindAsync(SelectedProperty);
            if (dbProperty == null)
            {
                return View("Error", new string[] { "Selected property does not exist." });
            }

            // Check for overlapping reservations
            var overlappingReservations = _context.Reservations
                .Where(r => r.Property.PropertyID == SelectedProperty &&
                            r.CheckIn < reservation.CheckOut &&
                            r.CheckOut > reservation.CheckIn)
                .ToList();

            if (overlappingReservations.Any())
            {
                return View("Error", new string[] { "This property is already reserved for the selected dates." });
            }

            // Fetch the current user
            var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (currentUser == null)
            {
                return View("Error", new string[] { "User not found. Please log in and try again." });
            }

            // Find or create the user's cart
            var userCart = await _context.Carts
                .Include(c => c.Reservations)
                .FirstOrDefaultAsync(c => c.User.UserName == currentUser.UserName);

            if (userCart == null)
            {
                userCart = new Cart
                {
                    User = currentUser,
                    Reservations = new List<Reservation>()
                };
                _context.Carts.Add(userCart);
                await _context.SaveChangesAsync();
            }

            // Populate reservation details
            reservation.Property = dbProperty;
            reservation.User = currentUser;
            reservation.WeekdayPrice = dbProperty.WeekdayPrice;
            reservation.WeekendPrice = dbProperty.WeekendPrice;
            reservation.CleaningFee = dbProperty.CleaningFee;
            reservation.DiscountRate = dbProperty.DiscountRate;
            reservation.ReservationStatus = ReservationStatus.Unconfirmed;

            // Add the reservation to the cart
            userCart.Reservations.Add(reservation);
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            // Redirect to the cart page
            return RedirectToAction("Index", "Cart");
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
    }
}
