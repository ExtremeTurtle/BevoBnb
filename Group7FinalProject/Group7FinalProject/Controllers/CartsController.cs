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
using Microsoft.AspNetCore.Identity;
using Group7FinalProject.Utilities;

namespace Group7FinalProject.Controllers
{
    public class CartsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CartsController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager; 
        }

        // GET: Carts
        public async Task<IActionResult> Index()
        {

            // Set up the cart to display
            Cart cart = await _context.Carts
                .Include(c => c.Reservations) // Include reservations in the cart
                .ThenInclude(r => r.Property)
                .FirstOrDefaultAsync(c => c.User.UserName == User.Identity.Name);

            if (cart == null || cart.Reservations.Count == 0)
            {
                return View("Error", new string[] { "Your cart is empty." });
            }

            return View(cart.Reservations);
        }

        // GET: Carts/Checkout
        public async Task<IActionResult> Checkout()
        {
            // Set up the cart to display
            Cart cart = await _context.Carts
                .Include(c => c.Reservations) // Include reservations in the cart
                .ThenInclude(r => r.Property)
                .FirstOrDefaultAsync(c => c.User.UserName == User.Identity.Name);

            if (cart == null || cart.Reservations.Count == 0)
            {
                return View("Error", new string[] { "Your cart is empty." });
            }

            // Calculate totals for each reservation
            foreach (var reservation in cart.Reservations)
            {
                reservation.CalcTotals();
            }

            decimal grandsubtotal = cart.Reservations.Sum(r => r.SubTotal);
            decimal grandtax = cart.Reservations.Sum(r => r.Tax);
            decimal grandtotal = cart.Reservations.Sum(r => r.TotalPrice);

            ViewBag.GrandSubTotal = grandsubtotal;
            ViewBag.GrandTax = grandtax;
            ViewBag.GrandTotal = grandtotal;


            return View(cart.Reservations);
        }
        [HttpPost]
        public async Task<IActionResult> ConfirmCheckout()
        {
            // Fetch the user's cart
            Cart cart = await _context.Carts
                .Include(c => c.Reservations)
                .ThenInclude(r => r.Property)
                .FirstOrDefaultAsync(c => c.User.UserName == User.Identity.Name);

            if (cart == null || !cart.Reservations.Any())
            {
                return View("Error", new string[] { "Your cart is empty. Cannot confirm checkout." });
            }

            // Generate a single confirmation number for all reservations in the cart
            int confirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(_context);

            // Confirm each reservation in the cart
            foreach (var reservation in cart.Reservations)
            {
                reservation.ReservationStatus = ReservationStatus.Valid;
                reservation.ConfirmationNumber = confirmationNumber; // Use the same confirmation number for all
                reservation.Cart = null; // Detach the reservation from the cart
               
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
            }
        

            // Clear the cart
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();

            // Redirect to a confirmation page
            return RedirectToAction("Confirmation", new { confirmationNumber = confirmationNumber });
        }

        [Authorize]
        public async Task<IActionResult> Confirmation(int confirmationNumber)
        {
            // Fetch all reservations with the given confirmation number
            List<Reservation> reservations;
            reservations = await _context.Reservations
                .Include(r => r.Property)
                .Where(r => r.ConfirmationNumber == confirmationNumber)
                .ToListAsync();

            // Calculate totals for each reservation
            foreach (var reservation in reservations)
            {
                reservation.CalcTotals();
            }
            if (!reservations.Any())
            {
                return View("Error", new string[] { "No reservations found for this confirmation number." });
            }

            ViewBag.ConfirmationNumber = confirmationNumber;
            return View(reservations);
        }





        // GET: Carts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CartID == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Carts/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Carts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CartID,UserID")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", cart.UserID);
            return View(cart);
        }

        // GET: Carts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", cart.UserID);
            return View(cart);
        }

        // POST: Carts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CartID,UserID")] Cart cart)
        {
            if (id != cart.CartID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.CartID))
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
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", cart.UserID);
            return View(cart);
        }

        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Reservation reservation = await _context.Reservations
                .Include(r => r.Cart) // Include the cart to which the reservation belongs
                .FirstOrDefaultAsync(r => r.ReservationID == id);

            if (reservation == null)
            {
                return View("Error", new string[] { "This reservation was not found!" });
            }

            if (reservation.Cart != null)
            {
                reservation.Cart.Reservations.Remove(reservation);
            }

            _context.Reservations.Remove(reservation);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index)); 

        }


            private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.CartID == id);
        }
    }
}
