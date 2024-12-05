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

namespace Group7FinalProject.Controllers
{
    [AllowAnonymous]
    public class PropertiesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public PropertiesController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            // Set up a list of Properties to display, including reviews for ratings
            List<Property> properties = _context.Properties
                                                .Include(p => p.Category)
                                                .Include(p => p.Reviews) // Include reviews for average rating
                                                .Where(p => p.PropertyStatus == PropertyStatus.Approved && p.ActiveStatus == Active.Active)
                                                .ToList();

            // Count total and filtered properties for display
            ViewBag.TotalProperties = _context.Properties.Count();
            ViewBag.FilteredProperties = properties.Count;

            return View(properties);
        }

        [Authorize(Roles = "Host")]
        public async Task<IActionResult> MyProperties()
        {
            List<Property> properties = _context.Properties
                                                .Include(p => p.Category)
                                                .Include(p => p.User)
                                                .Where(p => p.User.UserName == User.Identity.Name)
                                                .ToList();

            return View("Index", properties);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a Property to view!" });
            }

            Property property = await _context.Properties
                                              .Include(p => p.Category)
                                              .Include(p => p.Reviews) // Include reviews for ratings
                                              .FirstOrDefaultAsync(m => m.PropertyID == id);

            if (property == null)
            {
                return View("Error", new String[] { "This property was not found!" });
            }

            List<Review> reviews = property.Reviews
                                           .Where(r => r.DisputeStatus == DisputeStatus.NoDispute || r.DisputeStatus == DisputeStatus.InvalidDispute)
                                           .ToList();

            if (reviews.Count == 0)
            {
                ViewBag.AverageRating = "N/A";
            }
            else
            {
                ViewBag.AverageRating = reviews.Average(r => r.Rating);
            }

            return View(property);
        }

        [Authorize(Roles = "Host")]
        public IActionResult Create()
        {
            ViewBag.AllCategories = GetCategorySelectList();
            return View();
        }

        [Authorize(Roles = "Host")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Property property, int categoryID)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AllCategories = GetCategorySelectList();
                return View(property);
            }

            _context.Add(property);
            await _context.SaveChangesAsync();

            Category dbCategory = _context.Categories.Find(categoryID);
            property.User = await _userManager.FindByNameAsync(User.Identity.Name);
            property.PropertyStatus = PropertyStatus.Unapproved;
            property.Category = dbCategory;
            property.PropertyNumber = Utilities.GenerateNextPropertyNumber.GetNextPropertyNumber(_context);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Host")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a property to edit!" });
            }

            Property property = await _context.Properties
                                              .Include(c => c.User)
                                              .FirstOrDefaultAsync(c => c.PropertyID == id);

            if (property == null)
            {
                return View("Error", new string[] { "This property was not found!" });
            }

            if (User.IsInRole("Host") && property.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to edit this property!" });
            }

            return View(property);
        }

        [Authorize(Roles = "Host")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Property property)
        {
            if (id != property.PropertyID)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            Property dbProperty;

            try
            {
                dbProperty = _context.Properties.Include(c => c.User).Include(c => c.Category).FirstOrDefault(c => c.PropertyID == id);

                if (!ModelState.IsValid)
                {
                    return View(property);
                }

                dbProperty.WeekdayPrice = property.WeekdayPrice;
                dbProperty.WeekendPrice = property.WeekendPrice;
                dbProperty.CleaningFee = property.CleaningFee;
                dbProperty.ActiveStatus = property.ActiveStatus;

                _context.Properties.Update(dbProperty);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this property.", ex.Message });
            }

            return RedirectToAction(nameof(Index));
        }

        private SelectList GetCategorySelectList()
        {
            List<Category> allCategories = _context.Categories.ToList();
            SelectList slAllCategories = new SelectList(allCategories, nameof(Category.CategoryID), nameof(Category.CategoryName));
            return slAllCategories;
        }

        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyID == id);
        }
    }
}
