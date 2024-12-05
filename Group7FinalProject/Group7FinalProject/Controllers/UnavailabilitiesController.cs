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

        // GET: Unavailabilities/CreateRange
        [HttpGet]
        [Authorize(Roles = "Host")]
        public IActionResult Create(int? propertyID)
        {
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

            // Prepopulate default dates for convenience
            var model = new Unavailability
            {
                Property = dbProperty
            };

            // Optionally pre-fill default dates for convenience
            ViewBag.StartDate = DateTime.Today.ToString("yyyy-MM-dd");
            ViewBag.EndDate = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd");

            return View(model);
        }

        
            [HttpPost]
            [ValidateAntiForgeryToken]
            [Authorize(Roles = "Host")]
            public async Task<IActionResult> Create(int propertyID, DateTime startDate, DateTime endDate)
            {
                if (startDate >= endDate) // Use >= to ensure at least one day is selected
                {
                    ModelState.AddModelError("", "Start date must be before the end date.");

                    var property = await _context.Properties
                        .FirstOrDefaultAsync(p => p.PropertyID == propertyID && p.User.UserName == User.Identity.Name);

                    var model = new Unavailability { Property = property };
                    return View(model);
                }

                // Ensure the property belongs to the logged-in host
                Property dbProperty = await _context.Properties
                    .FirstOrDefaultAsync(p => p.PropertyID == propertyID
                        && p.User.UserName == User.Identity.Name);

                if (dbProperty == null)
                {
                    return Unauthorized();
                }

                // Generate the list of requested unavailable dates, excluding the end date
                var unavailabilityDates = Enumerable.Range(0, (endDate - startDate).Days)
                    .Select(offset => startDate.AddDays(offset))
                    .ToList();

                // Check for overlaps with existing unavailabilities
                var overlappingDates = _context.Unavailabilities
                    .Where(u => u.Property.PropertyID == propertyID && unavailabilityDates.Contains(u.UnavailableDate))
                    .Select(u => u.UnavailableDate)
                    .ToList();

                if (overlappingDates.Any())
                {
                    ModelState.AddModelError("", "The selected date range overlaps with existing unavailability on the following dates: " +
                        string.Join(", ", overlappingDates.Select(d => d.ToShortDateString())));

                    var model = new Unavailability { Property = dbProperty };
                    return View(model);
                }

                // Create new unavailabilities for dates that are not already marked
                var newUnavailabilities = unavailabilityDates
                    .Where(date => !_context.Unavailabilities.Any(u =>
                        u.Property.PropertyID == propertyID && u.UnavailableDate == date))
                    .Select(date => new Unavailability
                    {
                        UnavailableDate = date,
                        Property = dbProperty
                    }).ToList();

                _context.AddRange(newUnavailabilities);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
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

   
       

       

        private bool UnavailabilityExists(int id)
        {
            return _context.Unavailabilities.Any(e => e.UnavailabilityID == id);
        }
    }
}
