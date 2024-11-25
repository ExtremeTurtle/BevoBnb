using Group7FinalProject.DAL;
using Group7FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group7FinalProject.Seeding
{
    public static class SeedCategories
    {
        public static void SeedAllCategories(AppDbContext db)
        {
            // Define all categories
            List<Category> AllCategories = new List<Category>
            {
                new Category { CategoryName = "House" },
                new Category { CategoryName = "Cabin" },
                new Category { CategoryName = "Apartment" },
                new Category { CategoryName = "Condo" },
                new Category { CategoryName = "Hotel" }
            };

            // Debugging variables
            int intCategoryID = 0;
            string strCategoryName = "";

            try
            {
                // Loop through each category
                foreach (Category seedCategory in AllCategories)
                {
                    // Update debugging variables
                    strCategoryName = seedCategory.CategoryName;

                    // Check if category already exists in the database
                    Category dbCategory = db.Categories
                        .FirstOrDefault(c => c.CategoryName == seedCategory.CategoryName);

                    if (dbCategory == null) // Add if not found
                    {
                        db.Categories.Add(seedCategory);
                        db.SaveChanges();
                    }
                    else // Update if exists (if necessary)
                    {
                        dbCategory.CategoryName = seedCategory.CategoryName;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) // Handle errors
            {
                // Build detailed error message
                StringBuilder msg = new StringBuilder();
                msg.Append("There was an error adding the category: ");
                msg.Append(strCategoryName);
                msg.Append(" (CategoryID = ");
                msg.Append(intCategoryID);
                msg.Append(")");

                // Throw custom exception with details
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
