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
                                              .Include(p => p.Unavailabilities)
                                              .FirstOrDefaultAsync(m => m.PropertyID == id);

            if (property == null)
            {
                return View("Error", new String[] { "This property was not found!" });
            }

            List<Review> reviews;
            reviews = property.Reviews
             .Where(r => r.DisputeStatus == DisputeStatus.NoDispute || r.DisputeStatus == DisputeStatus.InvalidDispute).ToList();

            if (reviews.Any())
            {
                ViewBag.AverageRating = reviews.Average(r => r.Rating);
            }
            else
            {
                ViewBag.AverageRating = "N/A";
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

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApproveProperties()
        {
            List<Property> pendingProperties;

            pendingProperties = await _context.Properties
                                                  .Where(p => p.PropertyStatus == PropertyStatus.Unapproved)
                                                  .ToListAsync();
            return View(pendingProperties);
        }

        //Approve Properties
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Approve(int propertyId)
        {
            Property property = await _context.Properties.FindAsync(propertyId);
            if (property == null)
            {
                return NotFound();
            }

            property.PropertyStatus = PropertyStatus.Approved;
            _context.Update(property);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(ApproveProperties));
        }



        private SelectList GetAllCategoriesSelectList()
        {
            // Fetch categories from the database
            List<Category> categoryList = _context.Categories.ToList();

            // Add a default "All Categories" option
            categoryList.Insert(0, new Category
            {
                CategoryID = 0,
                CategoryName = "All Categories"
            });

            // Return a SelectList for dropdown binding
            return new SelectList(categoryList, "CategoryID", "CategoryName");
        }

        //detailed search
        public IActionResult DetailedSearch()
        {
            // Populate the ViewBag with categories
            ViewBag.AllCategories = GetAllCategoriesSelectList();

            // Initialize SearchViewModel with default values
            SearchViewModel svm = new SearchViewModel
            {
                SelectedCategory = 0,             // Default to "All Categories"
                SearchPetsAllowed = false,        // Default to no pets allowed
                SearchCheckInDate = DateTime.Now, // Default to today
                SearchCheckOutDate = DateTime.Now.AddDays(1) // Default to tomorrow
            };

            return View(svm);
        }

        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            // Start building the query to select all properties
            var query = from p in _context.Properties
                        .Include(p => p.Category)
                        .Include(p => p.Unavailabilities)// Include the Category navigation property
                        select p;

            // Filter by City if provided
            if (!string.IsNullOrEmpty(svm.SearchCity))
            {
                query = query.Where(p => p.City.Contains(svm.SearchCity));
            }

            // Filter by State if provided
            if (!string.IsNullOrEmpty(svm.SearchState))
            {
                query = query.Where(p => p.State.Contains(svm.SearchState));
            }

            //TODO Filter by Guest Rating --> create an average method for reviews on property


            // Filter by Daily Price
            //TODO Add logic so that price is different based on weekday vs weekend
            //if (svm.SearchDailyPrice.HasValue)
            //{
            //    if (svm.FilterDailyPrice == Filter.GreaterThan)
            //    {
            //        query = query.Where(p => p.DailyPrice >= svm.SearchDailyPrice);
            //    }
            //    else if (svm.FilterDailyPrice == Filter.LessThan)
            //    {
            //        query = query.Where(p => p.DailyPrice <= svm.SearchDailyPrice);
            //    }
            //}

            // Filter by Category if provided
            if (svm.SelectedCategory != 0) // Assuming 0 means "All Categories"
            {
                query = query.Where(p => p.Category.CategoryID == svm.SelectedCategory);
            }

            // Filter by number of Guests
            if (svm.SearchGuests.HasValue)
            {
                query = query.Where(p => p.GuestsAllowed >= svm.SearchGuests);
            }

            // Filter by number of Bedrooms
            if (svm.SearchBedrooms.HasValue)
            {
                query = query.Where(p => p.NumOfBedrooms >= svm.SearchBedrooms);
            }

            // Filter by number of Bathrooms
            if (svm.SearchBathrooms.HasValue)
            {
                query = query.Where(p => p.NumOfBathrooms >= svm.SearchBathrooms);
            }

            //// Filter by Pets Allowed
            //if (svm.SearchPetsAllowed.HasValue)
            //{
            //    query = query.Where(p => p.PetFriendly == true);
            //}

            //// Filter by Free Parking
            //if (svm.SearchFreeParking.HasValue)
            //{
            //    query = query.Where(p => p.HasParking == true);
            //}

            ////TODO Filter by Check-In and Check-Out Dates --> Figure out logic for searching by dates where property is available
            //if (svm.SearchCheckInDate.HasValue && svm.SearchCheckOutDate.HasValue)
            //{
            //    query = query.Where(p => p.Unavailabilities. <= svm.SearchCheckInDate &&
            //                             p.AvailableTo >= svm.SearchCheckOutDate);
            //}

            // Execute the query
            var selectedProperties = query.ToList();

            // Populate the ViewBag with the results
            ViewBag.TotalProperties = _context.Properties.Count();
            ViewBag.FilteredProperties = selectedProperties.Count;

            // Return the view with the filtered properties
            return View("Index", selectedProperties);
        }



    }
}
    

