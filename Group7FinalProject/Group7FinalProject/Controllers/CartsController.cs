using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group7FinalProject.DAL;
using Group7FinalProject.Models;

namespace Group7FinalProject.Controllers
{
    public class CartsController : Controller
    {
        private readonly AppDbContext _context;

        public CartsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Carts
        public async Task<IActionResult> Index()
        {

            // Set up the cart to display
            Cart cart = await _context.Carts
                .Include(c => c.Reservations) // Include reservations in the cart
                .ThenInclude(r => r.Property) // Include the related property for each reservation
                .FirstOrDefaultAsync(c => c.User.UserName == User.Identity.Name);

            if (cart == null || cart.Reservations.Count == 0)
            {
                return View("Error", new string[] { "Your cart is empty." });
            }

            return View(cart);
        }

        // POST: Cart/Checkout
        [HttpPost]
        public async Task<IActionResult> Checkout()
        {
            var userCart = await _context.Carts
                .Include(c => c.Reservations)
                .FirstOrDefaultAsync(c => c.User.UserName == User.Identity.Name);

            if (userCart == null || !userCart.Reservations.Any())
            {
                return View("Error", new string[] { "Your cart is empty." });
            }

            try
            {
                int confirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(_context);

                foreach (var reservation in userCart.Reservations)
                {
                    reservation.ReservationStatus = ReservationStatus.Valid;
                    reservation.ConfirmationNumber = confirmationNumber;
                }

                _context.Carts.Remove(userCart);
                await _context.SaveChangesAsync();

                return RedirectToAction("ThankYou", new { confirmationNumber });
            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "An error occurred during checkout.", ex.Message });
            }
        }
            // GET: Cart/ThankYou
            public IActionResult ThankYou(int confirmationNumber)
        {
            ViewBag.ConfirmationNumber = confirmationNumber;
            return View();
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

            var cart = await _context.Carts
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CartID == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            if (cart != null)
            {
                _context.Carts.Remove(cart);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.CartID == id);
        }
    }
}
