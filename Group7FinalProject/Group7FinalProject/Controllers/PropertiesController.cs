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

        [Authorize(Roles = "Host")]

        // GET: Properties
        public async Task<IActionResult> MyProperties()
        {
            //Set up a list of Properties to display
            List<Property> properties;


            properties = _context.Properties
                                .Include(r => r.Category).Include(r => r.User).Where(p => p.User.UserName != User.Identity.Name)
                                .ToList();

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
            //if the user didn't specify a property id, we can't show them 
            //the data, so show an error instead
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a property to edit!" });
            }

            //find the property in the database
            //be sure to change the data type to course instead of 'var'
            Property property = await _context.Properties.Include(c => c.User).FirstOrDefaultAsync(c => c.PropertyID == id);

            //if the property does not exist in the database, then show the user
            //an error message
            if (property == null)
            {
                return View("Error", new string[] { "This property was not found!" });
            }

            return View(property);
        }

        [Authorize(Roles = "Host")]
        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Property property)
        {
            //this is a security check to see if the user is trying to modify
            //a different record.  Show an error message
            if (id != property.PropertyID)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            if (ModelState.IsValid == false) //there is something wrong
            {
                return View(property);
            }

            //if code gets this far, attempt to edit the property
            try
            {
                //Find the property to edit in the database and include relevant 
                //navigational properties
                Property dbProperty = _context.Properties
                    .FirstOrDefault(c => c.PropertyID == property.PropertyID);

               

                //update the propertie's scalar properties
                dbProperty.WeekdayPrice = property.WeekdayPrice;
                dbProperty.WeekdayPrice = property.WeekdayPrice;
                dbProperty.CleaningFee = property.CleaningFee;

                //Update the Status
                dbProperty.PropertyStatus = property.PropertyStatus;



                //save the changes
                _context.Properties.Update(dbProperty);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this property.", ex.Message });
            }

            //if code gets this far, everything is okay
            //send the user back to the page with all the courses
            return RedirectToAction(nameof(Index));
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
