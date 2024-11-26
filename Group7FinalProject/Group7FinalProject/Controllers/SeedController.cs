using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


using Group7FinalProject.Models;
using Group7FinalProject.DAL;
using System;


namespace Group7FinalProject.Controllers
{
    public class SeedController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedController(AppDbContext db, UserManager<AppUser> um, RoleManager<IdentityRole> rm)
        {
            _context = db;
            _userManager = um;
            _roleManager = rm;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SeedProperties()
        {
            try
            {
                Seeding.SeedProperties.SeedAllProperties(_context);
            }
            catch (Exception ex)
            {
                //create a new list to hold all the errors
                List<String> errors = new List<String>();

                //add a generic message
                errors.Add("There was an error adding genres to the database!");

                //add the message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions (if there are any)
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error message with the list of errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        public IActionResult SeedReviews()
        {
            try
            {
                Seeding.SeedReviews.SeedAllReviews(_context);
            }
            catch (Exception ex)
            {
                //create a new list to hold all the errors
                List<String> errors = new List<String>();

                //add a generic message
                errors.Add("There was an error adding genres to the database!");

                //add the message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions (if there are any)
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error message with the list of errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        public IActionResult SeedReservations()
        {
            try
            {
                Seeding.SeedReservations.SeedAllReservations(_context);
            }
            catch (Exception ex)
            {
                //create a new list to hold all the errors
                List<String> errors = new List<String>();

                //add a generic message
                errors.Add("There was an error adding genres to the database!");

                //add the message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions (if there are any)
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error message with the list of errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        public IActionResult SeedUnavailabilities()
        {
            try
            {
                Seeding.SeedUnavailabilities.SeedAllUnavailabilities(_context);
            }
            catch (Exception ex)
            {
                //create a new list to hold all the errors
                List<String> errors = new List<String>();

                //add a generic message
                errors.Add("There was an error adding genres to the database!");

                //add the message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions (if there are any)
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error message with the list of errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        public async Task<IActionResult> SeedRoles()
            {
                try
                {
                    //call the method to seed the roles
                    await Seeding.SeedRoles.AddAllRoles(_roleManager);
                }
                catch (Exception ex)
                {
                    //add the error messages to a list of strings
                    List<String> errorList = new List<String>();

                    //Add the outer message
                    errorList.Add(ex.Message);

                    //Add the message from the inner exception
                    errorList.Add(ex.InnerException.Message);

                    //Add additional inner exception messages, if there are any
                    if (ex.InnerException.InnerException != null)
                    {
                        errorList.Add(ex.InnerException.InnerException.Message);
                    }

                    return View("Error", errorList);
                }

                //this is the happy path - seeding worked!
                return View("Confirm");
            }
            public async Task<IActionResult> SeedPeople()
            {
                try
                {
                    //call the method to seed the users
                    await Seeding.SeedUsers.SeedAllUsers(_userManager, _context);
                }
                catch (Exception ex)
                {
                    //add the error messages to a list of strings
                    List<String> errorList = new List<String>();

                    //Add the outer message
                    errorList.Add(ex.Message);

                    if (ex.InnerException != null)
                    {
                        //Add the message from the inner exception
                        errorList.Add(ex.InnerException.Message);

                        //Add additional inner exception messages, if there are any
                        if (ex.InnerException.InnerException != null)
                        {
                            errorList.Add(ex.InnerException.InnerException.Message);
                        }

                    }


                    return View("Error", errorList);
                }

                //this is the happy path - seeding worked!
                return View("Confirm");
            }


        }
    }


