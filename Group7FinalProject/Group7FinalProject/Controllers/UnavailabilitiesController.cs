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
    public class UnavailabilitiesController : Controller
    {
        private readonly AppDbContext _context;

        public UnavailabilitiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Unavailabilities
        public async Task<IActionResult> Index()
        {
            return View(await _context.Unavailabilities.ToListAsync());
        }

        // GET: Unavailabilities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unavailability = await _context.Unavailabilities
                .FirstOrDefaultAsync(m => m.UnavailabilityID == id);
            if (unavailability == null)
            {
                return NotFound();
            }

            return View(unavailability);
        }

        // GET: Unavailabilities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Unavailabilities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UnavailabilityID,UnavailableDate")] Unavailability unavailability)
        {
            if (ModelState.IsValid)
            {
                _context.Add(unavailability);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(unavailability);
        }

        // GET: Unavailabilities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unavailability = await _context.Unavailabilities.FindAsync(id);
            if (unavailability == null)
            {
                return NotFound();
            }
            return View(unavailability);
        }

        // POST: Unavailabilities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UnavailabilityID,UnavailableDate")] Unavailability unavailability)
        {
            if (id != unavailability.UnavailabilityID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unavailability);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnavailabilityExists(unavailability.UnavailabilityID))
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
            return View(unavailability);
        }

        // GET: Unavailabilities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unavailability = await _context.Unavailabilities
                .FirstOrDefaultAsync(m => m.UnavailabilityID == id);
            if (unavailability == null)
            {
                return NotFound();
            }

            return View(unavailability);
        }

        // POST: Unavailabilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var unavailability = await _context.Unavailabilities.FindAsync(id);
            if (unavailability != null)
            {
                _context.Unavailabilities.Remove(unavailability);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnavailabilityExists(int id)
        {
            return _context.Unavailabilities.Any(e => e.UnavailabilityID == id);
        }
    }
}
