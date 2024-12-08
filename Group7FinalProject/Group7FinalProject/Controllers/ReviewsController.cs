using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group7FinalProject.DAL;
using Group7FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Group7FinalProject.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ReviewsController(AppDbContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManager = userManger;
        }

        // GET: Reviews
        [Authorize]
        public async Task<IActionResult> Index()
        {
            List<Review> reviews = new List<Review>(); 

            if (User.IsInRole("Customer"))
            {
                reviews = await _context.Reviews
                .Include(r => r.User)
                .Include(r => r.Property)
                 .Where(r => r.User.UserName == User.Identity.Name)
                .ToListAsync();
            }

            if (User.IsInRole("Host"))
            {
                reviews = await _context.Reviews
                .Include(r => r.User)
                .Include(r => r.Property)
                 .Where(r => r.Property.User.UserName == User.Identity.Name)
                .ToListAsync();
            }

            if (User.IsInRole("Admin"))
            {
                reviews = await _context.Reviews
                .Include(r => r.User)
                .Include(r => r.Property)
                 .Where(r => r.DisputeStatus == DisputeStatus.Disputed)
                .ToListAsync();
            }



            if (!reviews.Any())
            {
                return View("NoReviews");
            }

            return View(reviews);
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        [Authorize(Roles = "Customer")]

        // GET: Reviews/Create
        [HttpGet]
        public async Task<IActionResult> Create(int? PropertyID)
        {
            if (PropertyID == null)
            {
                return View("Error", new string[] { "Please specify a property to add to the reservation" });
            }

            //find the property in the database
            Property dbProperty = _context.Properties.Find(PropertyID);

            //make sure the Property exists in the database
            if (dbProperty == null)
            {
                return View("Error", new string[] { "This Property was not in the database!" });
            }

            
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            // Validation 1: Check if the user has already reviewed this property
            bool hasReviewed = _context.Reviews.Any(r => r.Property.PropertyID == PropertyID && r.User.UserName == user.UserName);
            if (hasReviewed)
            {
                return View("Error", new string[] { "You have already reviewed this property." });
            }

            // Validation 2: Check if the user has a valid reservation for this property
            var now = DateTime.Now;
            bool hasValidReservation = _context.Reservations.Any(res =>
                res.Property.PropertyID == PropertyID &&
                res.User.UserName == user.UserName &&
                res.CheckOut<= now // Ensure the reservation is in the past or ongoing
            );

            if (!hasValidReservation)
            {
                return View("Error", new string[] { "You can only review properties where you have a valid past or ongoing reservation." });
            }

            Review review = new Review();
            review.Property = dbProperty;
            review.User = user;

            return View(review);
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Customer")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Review review, int PropertyID)
        {
            if (ModelState.IsValid == false)
            {
                return View(review);
            }

            

            review.User = await _userManager.FindByNameAsync(User.Identity.Name);
            if (review.User == null)
            {
                return View("Error", new string[] { "The user could not be found." });
            }

            // Find the property
            Property dbProperty = _context.Properties.Find(PropertyID);
            if (dbProperty == null)
            {
                return View("Error", new string[] { "This property could not be found." });
            }

            // Associate the property with the review
            review.Property = dbProperty;
            //add the review to the database and save changes
            _context.Add(review);
            await _context.SaveChangesAsync();


            //Send the user to the page with all the properties
            return RedirectToAction(nameof(Index));


        }

        [Authorize(Roles = "Customer")]

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //if the user didn't specify a review id, we can't show them 
            //the data, so show an error instead
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a review to edit!" });
            }

            //find the review in the database
            //be sure to change the data type to course instead of 'var'
            Review review = await _context.Reviews.Include(c => c.User).Include(c => c.Property).FirstOrDefaultAsync(c => c.ReviewID == id);

            //if the review does not exist in the database, then show the user
            //an error message
            if (review == null)
            {
                return View("Error", new string[] { "This review was not found!" });
            }

            //order does not belong to this user
            if (User.IsInRole("Host") && review.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to edit this review!" });
            }

            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Customer")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  Review review)
        {
            //this is a security check to see if the user is trying to modify
            //a different record.  Show an error message
            if (id != review.ReviewID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }


            Review dbReview;

           

            //if code gets this far, attempt to edit the review
            try
            {
                //Find the review to edit in the database and include relevant 
                //navigational properties
                 dbReview = await _context.Reviews.Include(c => c.User).Include(c => c.Property).FirstOrDefaultAsync(c => c.ReviewID == id);

                
                if (ModelState.IsValid == false) //there is something wrong
                {
                    return View(review);
                }
                //update the properties scalar properties
                dbReview.Rating = review.Rating;
                dbReview.ReviewText = string.IsNullOrEmpty(review.ReviewText) ? null : review.ReviewText;
                dbReview.DisputeStatus = DisputeStatus.NoDispute;



                //save the changes
                _context.Reviews.Update(dbReview);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this review.", ex.Message });
            }

            //if code gets this far, everything is okay
            //send the user back to the page with all the courses
            return RedirectToAction(nameof(Index));
        }

       


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AcceptDisputeReview(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a review with a dispute to accept!" });
            }

            // Find the reservation in the database
            
            Review review = await _context.Reviews
                .Include(r => r.User)
                .FirstOrDefaultAsync(r => r.ReviewID == id);



            if (review == null)
            {
                return View("Error", new string[] { "This review was not found!" });
            }



            // Update the reservation status
            review.DisputeStatus = DisputeStatus.ValidDispute;

            // Save the changes
            await _context.SaveChangesAsync();

            // Redirect to the reservations index
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeclineDisputeReview(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a review with a dispute to decline!" });
            }

            // Find the reservation in the database
            Review review = await _context.Reviews
                .Include(r => r.User)
                
                .FirstOrDefaultAsync(r => r.ReviewID == id);



            if (review == null)
            {
                return View("Error", new string[] { "This review was not found!" });
            }



            // Update the reservation status
            review.DisputeStatus = DisputeStatus.InvalidDispute;

            // Save the changes
            await _context.SaveChangesAsync();

            // Redirect to the reservations index
            return RedirectToAction(nameof(Index));
        }


        [Authorize(Roles = "Host")]
        public async Task<IActionResult> DisputeReview(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a review to dispute!" });
            }

            // Find the review in the database
            Review review = await _context.Reviews
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ReviewID == id && r.Property.User.UserName == User.Identity.Name);

            if (review == null)
            {
                return View("Error", new string[] { "This review was not found or does not belong to one of your properties!" });
            }

            // Check if the review is already disputed
            if (review.DisputeStatus == DisputeStatus.Disputed)
            {
                return View("Error", new string[] { "This review is already disputed!" });
            }

            return View(review);
        }

        [Authorize(Roles = "Host")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DisputeReview(int id, [Bind("ReviewID,HostComments")] Review review)
        {
            if (id != review.ReviewID)
            {
                return View("Error", new string[] { "Please specify a valid review to dispute!" });
            }

            if (string.IsNullOrWhiteSpace(review.HostComments))
            {
                ModelState.AddModelError("", "Please provide a comment explaining why this review should be disputed.");
                return View(review);
            }

            try
            {
                // Find the review to dispute
                Review dbReview = await _context.Reviews
                    .Include(r => r.Property)
                    .FirstOrDefaultAsync(r => r.ReviewID == id && r.Property.User.UserName == User.Identity.Name);

                if (dbReview == null)
                {
                    return View("Error", new string[] { "This review was not found or does not belong to one of your properties!" });
                }

                // Check if the review is already disputed
                if (dbReview.DisputeStatus == DisputeStatus.Disputed)
                {
                    return View("Error", new string[] { "This review is already disputed!" });
                }

                // Update the review's dispute status and host comments
                dbReview.DisputeStatus = DisputeStatus.Disputed;
                dbReview.HostComments = review.HostComments;

                // Save changes to the database
                _context.Reviews.Update(dbReview);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error disputing this review.", ex.Message });
            }
        }



        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.ReviewID == id);
        }
    }
}
