//TODO: Change these using statements to match your project
using Group7FinalProject.DAL;
using Group7FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

//TODO: Change this namespace to match your project
namespace Group7FinalProject.Controllers
{
    //TODO: Uncomment this line once you have roles working correctly
    [Authorize(Roles = "Admin")]
    public class RoleAdminController : Controller
    {
        //create private variables for the services needed in this controller
        private AppDbContext _context;
        private UserManager<AppUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;


        //RoleAdminController constructor
        public RoleAdminController(AppDbContext appDbContext, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //populate the values of the variables passed into the controller
            _context = appDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: /RoleAdmin/
        public async Task<ActionResult> Index()
        {
            //Create a list of roles that will need to be edited
            List<RoleEditModel> roles = new List<RoleEditModel>();

            //loop through each of the existing roles
            foreach (IdentityRole role in _roleManager.Roles)
            {
                //this is a list of all the users who ARE in this role (members)
                List<AppUser> RoleMembers = new List<AppUser>();

                //this is a list of all the users who ARE NOT in this role (non-members)
                List<AppUser> RoleNonMembers = new List<AppUser>();

                //loop through ALL the users and decide if they are in the role(member) or not (non-member)
                //every user will be evaluated for every role, so this is a SLOW chunk of code because
                //it accesses the database so many times
                foreach (AppUser user in _userManager.Users)
                {
                    if (await _userManager.IsInRoleAsync(user, role.Name) == true) //user is in the role
                    {
                        //add user to list of members
                        RoleMembers.Add(user);
                    }
                    else //user is NOT in the role
                    {
                        //add user to list of non-members
                        RoleNonMembers.Add(user);
                    }
                }

                //create a new instance of the role edit model
                RoleEditModel rem = new RoleEditModel();

                //populate the properties of the role edit model
                rem.Role = role; //role from database
                rem.RoleMembers = RoleMembers; //list of users in this role
                rem.RoleNonMembers = RoleNonMembers; //list of users NOT in this role

                //add this role to the list of role edit models
                roles.Add(rem);
            }

            //pass the list of roles to the view
            return View(roles);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create([Required] string name)
        {
            if (ModelState.IsValid)
            {
                //attempt to create the new role using the role manager
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(name));

                //if the role was created successfully, take the user to the index page
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else //role was not added succesfully, so add errors to model 
                //and let the user try again
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            //if code gets this far, we need to show an error
            return View(name);
        }

        public async Task<ActionResult> Edit(string id)
        {
            //look up the role requested by the user
            IdentityRole role = await _roleManager.FindByIdAsync(id);

            //create a list for the members of the role
            List<AppUser> RoleMembers = new List<AppUser>();

            //create a list for the non-members of the role
            List<AppUser> RoleNonMembers = new List<AppUser>();

            //through ALL the users and decide if they are in the role(member) or not (non-member)
            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name) == true) //user is in the role
                {
                    //add the user to the list of members
                    RoleMembers.Add(user);
                }
                else //user is NOT in the role
                {
                    RoleNonMembers.Add(user);
                }
            }

            //create a new instance of the role edit model
            RoleEditModel rem = new RoleEditModel();

            //populate the properties of the role edit model
            rem.Role = role; //role looked up from database
            rem.RoleMembers = RoleMembers; //list of users in the role
            rem.RoleNonMembers = RoleNonMembers; //list of users NOT in the role

            //send user to view with populated role edit model
            return View(rem);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoleModificationModel rmm)
        {
            if (rmm.RoleName == "Admin")
            {
                // Restrict modifications to role membership for Admin
                return Unauthorized("Modifying Admin role membership is not allowed.");
            }

            // Continue normal role editing for non-admin roles
            IdentityResult result;

            if (ModelState.IsValid)
            {
                if (rmm.IdsToAdd != null)
                {
                    foreach (string userId in rmm.IdsToAdd)
                    {
                        AppUser user = await _userManager.FindByIdAsync(userId);
                        result = await _userManager.AddToRoleAsync(user, rmm.RoleName);

                        if (!result.Succeeded)
                        {
                            return View("Error", result.Errors);
                        }
                    }
                }

                if (rmm.IdsToDelete != null)
                {
                    foreach (string userId in rmm.IdsToDelete)
                    {
                        AppUser user = await _userManager.FindByIdAsync(userId);
                        result = await _userManager.RemoveFromRoleAsync(user, rmm.RoleName);

                        if (!result.Succeeded)
                        {
                            return View("Error", result.Errors);
                        }
                    }
                }

                return RedirectToAction("Index");
            }

            return View("Error", new string[] { "Role not found" });
        }


        [HttpPost]
        public async Task<IActionResult> FireAdmin(string userId)
        {
            // Find the user by ID
            AppUser admin = await _userManager.FindByIdAsync(userId);

            if (admin == null)
            {
                return NotFound();
            }

            // Update the HireStatus to Fired
            admin.HireStatus = HireStatus.Fired;

            // Save the changes
            var result = await _userManager.UpdateAsync(admin);

            if (!result.Succeeded)
            {
                // If there were errors, display them
                return View("Error", result.Errors);
            }

            return RedirectToAction("Index", "RoleAdmin");
        }

        [HttpPost]
        public async Task<IActionResult> RehireAdmin(string userId)
        {
            // Find the user by ID
            AppUser admin = await _userManager.FindByIdAsync(userId);

            if (admin == null)
            {
                return NotFound();
            }

            // Update the HireStatus to Employed
            admin.HireStatus = HireStatus.Employed;

            // Save the changes
            var result = await _userManager.UpdateAsync(admin);

            if (!result.Succeeded)
            {
                // If there were errors, display them
                return View("Error", result.Errors);
            }

            return RedirectToAction("Index", "RoleAdmin");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditUserProfile(string email)
        {
            // Find the user by email
            AppUser user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return View("Error", new string[] { "User not found." });
            }

            // Populate the EditUserProfileViewModel
            EditUserProfileViewModel model = new EditUserProfileViewModel
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                Birthday = user.Birthday
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUserProfile(EditUserProfileViewModel model, string? newPassword)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Validate that the user is at least 18 years old
            if (model.Birthday.AddYears(18) > DateTime.Today)
            {
                ModelState.AddModelError("Birthday", "The user must be at least 18 years old.");
                return View(model); // Return the view with the validation error
            }

            // Find the user by email
            AppUser user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                return View("Error", new string[] { "User not found." });
            }

            // Update user properties
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.PhoneNumber;
            user.Address = model.Address;
            user.Birthday = model.Birthday;

            // Save profile changes
            var updateResult = await _userManager.UpdateAsync(user);

            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }

            // Update password if provided
            if (!string.IsNullOrEmpty(newPassword))
            {
                // Generate password reset token
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                // Reset the password
                var passwordResult = await _userManager.ResetPasswordAsync(user, token, newPassword);

                if (!passwordResult.Succeeded)
                {
                    foreach (var error in passwordResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
            }

            ViewBag.Message = "User profile updated successfully!";
            return RedirectToAction("Index", "RoleAdmin");
        }






    }
}