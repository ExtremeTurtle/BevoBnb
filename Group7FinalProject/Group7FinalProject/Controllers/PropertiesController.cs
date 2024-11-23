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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static NuGet.Packaging.PackagingConstants;
using NuGet.Packaging.Signing;

namespace Group7FinalProject.Controllers
{
    [AllowAnonymous]
    public class PropertiesController : Controller
    {
        private readonly AppDbContext _context;

        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            //Set up a list of Properties to display
            List<Property> properties;

            properties = _context.Properties
                                .Include(r => r.Category).
                                Where(p => p.PropertyStatus == PropertyStatus.Approved).ToList();

            return View(properties);

        }

        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //the user did not specify a order to view
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a Property to view!" });
            }

            //find the order in the database
            Property property = await _context.Properties
                                              .Include(r => r.Category)
                                              .Include(r =>r.Reviews)
                                              .Include(r => r. Unavailabilities)
                                              .FirstOrDefaultAsync(m => m.PropertyID == id);

            //order was not found in the database
            if (property == null)
            {
                return View("Error", new String[] { "This property was not found!" });
            }

           

            //Send the user to the details page
            return View(property);
        }

        [Authorize(Roles = "Host")]
        // GET: Properties/Create
        public IActionResult Create()
        {
            ViewBag.AllCateogires = GetCategorySelectList();
            return View();
        }

        [Authorize(Roles = "Host")]
        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Property property, int categoryID) //Add code to bind user
        {
            //This code has been modified so that if the model state is not valid
            //we immediately go to the "sad path" and give the user a chance to try again
            if (ModelState.IsValid == false)
            {
                //re-populate the view bag with the categories
                ViewBag.AllCategories = GetCategorySelectList();
                //go back to the Create view to try again
                return View(property);
            }

            //if code gets to this point, we know the model is valid and
            //we can add the property to the database

            //add the property to the database and save changes
            _context.Add(property);
            await _context.SaveChangesAsync();

            //add the associated Category to the Property
            
            //find the Category associated with that id
            Category dbCategory = _context.Categories.Find(categoryID);

            //add the category to the Property's category and save changes
            property.PropertyStatus = PropertyStatus.Unapproved;
            property.Category = dbCategory;
            _context.SaveChanges();
            

            //Send the user to the page with all the properties
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Host")]
        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }
            return View(@property);
        }

        [Authorize(Roles = "Host")]
        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyID,PropertyNumber,Address,City,State,ZipCode,NumOfBedrooms,NumOfBathrooms,GuestsAllowed,WeekdayPrice,WeekendPrice,CleaningFee,DiscountRate,MinNightsForDiscount,PetFriendly,HasParking,PropertyStatus")] Property @property)
        {
            if (id != @property.PropertyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyExists(@property.PropertyID))
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
            return View(@property);
        }

       

        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyID == id);
        }

        private SelectList GetCategorySelectList()
        {
            //create a list for all the products
            List<Category> allCategories = _context.Categories.ToList();

            //the user MUST select a product, so you don't need a dummy option for no product

            //use the constructor on select list to create a new select list with the options
            SelectList slAllCategories = new SelectList(allCategories, nameof(Category.CategoryID), nameof(Category.CategoryName));

            return slAllCategories;
        }


        //See Properties needing approval
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
    }
}
