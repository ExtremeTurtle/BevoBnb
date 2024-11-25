using Group7FinalProject.DAL;
using Microsoft.SqlServer.Server;
using Group7FinalProject.Utilities;
using Group7FinalProject.Models;

namespace Group7FinalProject.Seeding
{
    public static class SeedingDemo
    {
        public static void SeedOneProperty(AppDbContext db)
        {
            Property property = new Property()
            {
                ZipCode = "72227",
                State = "PA",
                Address = "8714 Mann Plaza",
                City = "Lisaside",
                WeekendPrice = 171.51m,
                WeekdayPrice = 152.68m,
                PetFriendly = false,
                HasParking = false,
                CleaningFee = 8.88m,
                NumOfBedrooms = 5,
                NumOfBathrooms = 6,
                GuestsAllowed = 9,
                MinNightsForDiscount = 4,
                DiscountRate = .014m,
                PropertyStatus = PropertyStatus.Approved

            }
            property.User = db.Users.FirstOrDefault(g => g.Email == "gonzalez@aol.com");
            property.Category = db.Categories.FirstOrDefault(g => g.CategoryName == "House");
        }
    }
}


