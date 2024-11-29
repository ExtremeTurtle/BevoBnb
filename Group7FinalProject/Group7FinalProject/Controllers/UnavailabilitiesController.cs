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

   
       

       

        private bool UnavailabilityExists(int id)
        {
            return _context.Unavailabilities.Any(e => e.UnavailabilityID == id);
        }
    }
}
