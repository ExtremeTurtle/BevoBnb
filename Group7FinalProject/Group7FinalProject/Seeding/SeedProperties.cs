
using Group7FinalProject.DAL;
using Group7FinalProject.Models;
using System.Text;

namespace Group7FinalProject.Seeding
{

    public static class SeedProperties
    {
        public static void SeedAllProperties(AppDbContext db)
        {
            // Define all property records
            List<Property> AllProperties = new List<Property>();

            AllProperties.Add(new Property
            {
                PropertyNumber = 3001,
                Address = "8714 Mann Plaza",
                City = "Lisaside",
                State = "PA",
                ZipCode = "72227",
                NumOfBedrooms = 5,
                NumOfBathrooms = 6,
                GuestsAllowed = 9,
                WeekdayPrice = 152.68m,
                WeekendPrice = 171.57m,
                CleaningFee = 8.88m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3002,
                Address = "96593 White View Apt. 094",
                City = "Jonesberg",
                State = "FL",
                ZipCode = "5565",
                NumOfBedrooms = 7,
                NumOfBathrooms = 8,
                GuestsAllowed = 8,
                WeekdayPrice = 120.81m,
                WeekendPrice = 148.15m,
                CleaningFee = 8.02m,
                DiscountRate = 0.14m,
                MinNightsForDiscount = 4,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3003,
                Address = "848 Melissa Springs Suite 947",
                City = "Kellerstad",
                State = "MD",
                ZipCode = "80819",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 8,
                WeekdayPrice = 127.96m,
                WeekendPrice = 132.99m,
                CleaningFee = 13.37m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Unapproved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3004,
                Address = "30413 Norton Isle Suite 012",
                City = "North Lisa",
                State = "ND",
                ZipCode = "79428",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 14,
                WeekdayPrice = 80.20m,
                WeekendPrice = 185.35m,
                CleaningFee = 5.57m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3005,
                Address = "39916 Mitchell Crescent",
                City = "New Andrewburgh",
                State = "DE",
                ZipCode = "63315",
                NumOfBedrooms = 2,
                NumOfBathrooms = 3,
                GuestsAllowed = 12,
                WeekdayPrice = 170.25m,
                WeekendPrice = 100.37m,
                CleaningFee = 18.64m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3006,
                Address = "086 Mary Cliff",
                City = "North Deborah",
                State = "NE",
                ZipCode = "24135",
                NumOfBedrooms = 7,
                NumOfBathrooms = 9,
                GuestsAllowed = 2,
                WeekdayPrice = 220.24m,
                WeekendPrice = 162.60m,
                CleaningFee = 10.83m,
                DiscountRate = 0.24m,
                MinNightsForDiscount = 10,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3007,
                Address = "91634 Strong Mountains Apt. 302",
                City = "West Alyssa",
                State = "PA",
                ZipCode = "58475",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 9,
                WeekdayPrice = 213.37m,
                WeekendPrice = 204.87m,
                CleaningFee = 25.04m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3008,
                Address = "6984 Price Shoals",
                City = "Erictown",
                State = "WA",
                ZipCode = "10865",
                NumOfBedrooms = 2,
                NumOfBathrooms = 3,
                GuestsAllowed = 8,
                WeekdayPrice = 159.69m,
                WeekendPrice = 140.89m,
                CleaningFee = 27.13m,
                DiscountRate = 0.05m,
                MinNightsForDiscount = 7,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3009,
                Address = "423 Bell Heights",
                City = "Brittanyberg",
                State = "ME",
                ZipCode = "51359",
                NumOfBedrooms = 3,
                NumOfBathrooms = 3,
                GuestsAllowed = 4,
                WeekdayPrice = 200.73m,
                WeekendPrice = 295.39m,
                CleaningFee = 14.91m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3010,
                Address = "93523 Dana Lane",
                City = "Johnsonshire",
                State = "WI",
                ZipCode = "87296",
                NumOfBedrooms = 6,
                NumOfBathrooms = 6,
                GuestsAllowed = 3,
                WeekdayPrice = 170.39m,
                WeekendPrice = 110.80m,
                CleaningFee = 8.67m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3011,
                Address = "1427 Odonnell Rapids",
                City = "North Troyport",
                State = "NH",
                ZipCode = "7035",
                NumOfBedrooms = 3,
                NumOfBathrooms = 3,
                GuestsAllowed = 14,
                WeekdayPrice = 217.15m,
                WeekendPrice = 126.29m,
                CleaningFee = 26.48m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3012,
                Address = "81206 Stewart Forest Apt. 089",
                City = "East Davidborough",
                State = "ME",
                ZipCode = "37198",
                NumOfBedrooms = 3,
                NumOfBathrooms = 5,
                GuestsAllowed = 8,
                WeekdayPrice = 205.21m,
                WeekendPrice = 293.26m,
                CleaningFee = 28.74m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3013,
                Address = "76104 Marsh Crescent",
                City = "Dennishaven",
                State = "SD",
                ZipCode = "85034",
                NumOfBedrooms = 7,
                NumOfBathrooms = 7,
                GuestsAllowed = 4,
                WeekdayPrice = 123.13m,
                WeekendPrice = 126.99m,
                CleaningFee = 18.73m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3014,
                Address = "0003 Grant Lakes",
                City = "Port Karafort",
                State = "SD",
                ZipCode = "60619",
                NumOfBedrooms = 3,
                NumOfBathrooms = 5,
                GuestsAllowed = 14,
                WeekdayPrice = 89.19m,
                WeekendPrice = 188.81m,
                CleaningFee = 11.98m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Unapproved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3015,
                Address = "236 Smith Drive Suite 555",
                City = "West Kimberlyton",
                State = "KY",
                ZipCode = "21978",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 11,
                WeekdayPrice = 198.30m,
                WeekendPrice = 132.96m,
                CleaningFee = 13.96m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3016,
                Address = "6824 Timothy Garden Apt. 428",
                City = "West Richardmouth",
                State = "MT",
                ZipCode = "14742",
                NumOfBedrooms = 6,
                NumOfBathrooms = 6,
                GuestsAllowed = 10,
                WeekdayPrice = 181.50m,
                WeekendPrice = 297.31m,
                CleaningFee = 10.09m,
                DiscountRate = 0.13m,
                MinNightsForDiscount = 22,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3017,
                Address = "5517 Holly Meadow Apt. 452",
                City = "Lake Anne",
                State = "SC",
                ZipCode = "11894",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 1,
                WeekdayPrice = 134.09m,
                WeekendPrice = 139.22m,
                CleaningFee = 9.75m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3018,
                Address = "30601 Hawkins Highway",
                City = "Morashire",
                State = "TX",
                ZipCode = "28976",
                NumOfBedrooms = 6,
                NumOfBathrooms = 5,
                GuestsAllowed = 9,
                WeekdayPrice = 187.65m,
                WeekendPrice = 160.61m,
                CleaningFee = 7.50m,
                DiscountRate = 0.11m,
                MinNightsForDiscount = 30,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3019,
                Address = "49263 Wilson View Apt. 873",
                City = "South Raymondborough",
                State = "AZ",
                ZipCode = "28798",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 5,
                WeekdayPrice = 206.95m,
                WeekendPrice = 133.25m,
                CleaningFee = 14.04m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3020,
                Address = "76582 Vanessa Oval",
                City = "New Richard",
                State = "NE",
                ZipCode = "68819",
                NumOfBedrooms = 5,
                NumOfBathrooms = 4,
                GuestsAllowed = 12,
                WeekdayPrice = 99.54m,
                WeekendPrice = 242.89m,
                CleaningFee = 6.61m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3021,
                Address = "7389 Alec Squares Suite 508",
                City = "Port Jonathan",
                State = "FL",
                ZipCode = "50177",
                NumOfBedrooms = 7,
                NumOfBathrooms = 7,
                GuestsAllowed = 12,
                WeekdayPrice = 112.62m,
                WeekendPrice = 165.32m,
                CleaningFee = 24.26m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3022,
                Address = "18013 Billy Bridge Suite 522",
                City = "Schmitthaven",
                State = "NC",
                ZipCode = "66355",
                NumOfBedrooms = 3,
                NumOfBathrooms = 4,
                GuestsAllowed = 2,
                WeekdayPrice = 199.21m,
                WeekendPrice = 119.02m,
                CleaningFee = 11.63m,
                DiscountRate = 0.13m,
                MinNightsForDiscount = 21,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3023,
                Address = "891 Bullock Ford",
                City = "Amandachester",
                State = "NJ",
                ZipCode = "51431",
                NumOfBedrooms = 5,
                NumOfBathrooms = 6,
                GuestsAllowed = 11,
                WeekdayPrice = 179.05m,
                WeekendPrice = 244.93m,
                CleaningFee = 21.78m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3024,
                Address = "02489 Cook Park",
                City = "Sherriport",
                State = "MT",
                ZipCode = "50853",
                NumOfBedrooms = 4,
                NumOfBathrooms = 3,
                GuestsAllowed = 6,
                WeekdayPrice = 207.24m,
                WeekendPrice = 227.35m,
                CleaningFee = 5.50m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3025,
                Address = "23450 Timothy Divide",
                City = "Wuland",
                State = "UT",
                ZipCode = "20341",
                NumOfBedrooms = 3,
                NumOfBathrooms = 4,
                GuestsAllowed = 11,
                WeekdayPrice = 116.01m,
                WeekendPrice = 278.36m,
                CleaningFee = 24.73m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3026,
                Address = "0976 Williams Mountains Apt. 009",
                City = "Lake Mario",
                State = "OH",
                ZipCode = "85565",
                NumOfBedrooms = 6,
                NumOfBathrooms = 7,
                GuestsAllowed = 7,
                WeekdayPrice = 225.14m,
                WeekendPrice = 293.42m,
                CleaningFee = 10.42m,
                DiscountRate = 0.06m,
                MinNightsForDiscount = 28,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3027,
                Address = "1097 Santos Springs Suite 264",
                City = "New Michelleborough",
                State = "WY",
                ZipCode = "51884",
                NumOfBedrooms = 2,
                NumOfBathrooms = 2,
                GuestsAllowed = 4,
                WeekdayPrice = 70.24m,
                WeekendPrice = 126.45m,
                CleaningFee = 18.69m,
                DiscountRate = 0.08m,
                MinNightsForDiscount = 3,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3028,
                Address = "5100 Scott Burg",
                City = "East Clayton",
                State = "SC",
                ZipCode = "66353",
                NumOfBedrooms = 4,
                NumOfBathrooms = 3,
                GuestsAllowed = 3,
                WeekdayPrice = 186.38m,
                WeekendPrice = 224.07m,
                CleaningFee = 28.24m,
                DiscountRate = 0.06m,
                MinNightsForDiscount = 20,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3029,
                Address = "412 Snow Manors Apt. 161",
                City = "South Kimtown",
                State = "NV",
                ZipCode = "57004",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 9,
                WeekdayPrice = 112.47m,
                WeekendPrice = 120.93m,
                CleaningFee = 23.28m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3030,
                Address = "5415 David Square",
                City = "West Michaeltown",
                State = "IN",
                ZipCode = "48447",
                NumOfBedrooms = 7,
                NumOfBathrooms = 9,
                GuestsAllowed = 1,
                WeekdayPrice = 214.81m,
                WeekendPrice = 100.02m,
                CleaningFee = 17.78m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3031,
                Address = "03104 Norris Rapids",
                City = "Port Donald",
                State = "DE",
                ZipCode = "62982",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 11,
                WeekdayPrice = 159.87m,
                WeekendPrice = 161.60m,
                CleaningFee = 10.34m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3032,
                Address = "03557 Phillips Wells Suite 291",
                City = "New Beverlyburgh",
                State = "FL",
                ZipCode = "16915",
                NumOfBedrooms = 7,
                NumOfBathrooms = 6,
                GuestsAllowed = 4,
                WeekdayPrice = 70.55m,
                WeekendPrice = 203.60m,
                CleaningFee = 5.09m,
                DiscountRate = 0.23m,
                MinNightsForDiscount = 30,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3033,
                Address = "332 Watson Shore Apt. 290",
                City = "Millerland",
                State = "MT",
                ZipCode = "39742",
                NumOfBedrooms = 3,
                NumOfBathrooms = 3,
                GuestsAllowed = 2,
                WeekdayPrice = 176.37m,
                WeekendPrice = 299.34m,
                CleaningFee = 17.38m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3034,
                Address = "645 John Roads",
                City = "Danahaven",
                State = "MS",
                ZipCode = "54060",
                NumOfBedrooms = 7,
                NumOfBathrooms = 6,
                GuestsAllowed = 14,
                WeekdayPrice = 172.83m,
                WeekendPrice = 229.98m,
                CleaningFee = 23.55m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3035,
                Address = "3547 Stephanie Underpass Apt. 418",
                City = "Port Jacqueline",
                State = "HI",
                ZipCode = "55774",
                NumOfBedrooms = 1,
                NumOfBathrooms = 1,
                GuestsAllowed = 5,
                WeekdayPrice = 177.08m,
                WeekendPrice = 143.71m,
                CleaningFee = 19.21m,
                DiscountRate = 0.13m,
                MinNightsForDiscount = 42,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3036,
                Address = "5825 Welch Corners",
                City = "Fischerport",
                State = "UT",
                ZipCode = "59363",
                NumOfBedrooms = 3,
                NumOfBathrooms = 4,
                GuestsAllowed = 10,
                WeekdayPrice = 76.66m,
                WeekendPrice = 113.86m,
                CleaningFee = 27.87m,
                DiscountRate = 0.11m,
                MinNightsForDiscount = 7,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3037,
                Address = "41489 Roger Terrace",
                City = "Davisfort",
                State = "IN",
                ZipCode = "71770",
                NumOfBedrooms = 6,
                NumOfBathrooms = 8,
                GuestsAllowed = 6,
                WeekdayPrice = 177.37m,
                WeekendPrice = 299.09m,
                CleaningFee = 23.78m,
                DiscountRate = 0.09m,
                MinNightsForDiscount = 19,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3038,
                Address = "014 Aaron Locks Suite 714",
                City = "Justinborough",
                State = "CO",
                ZipCode = "5147",
                NumOfBedrooms = 2,
                NumOfBathrooms = 2,
                GuestsAllowed = 5,
                WeekdayPrice = 104.05m,
                WeekendPrice = 158.42m,
                CleaningFee = 5.36m,
                DiscountRate = 0.23m,
                MinNightsForDiscount = 30,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3039,
                Address = "8518 Pamela Track Apt. 164",
                City = "Aprilshire",
                State = "SC",
                ZipCode = "28062",
                NumOfBedrooms = 3,
                NumOfBathrooms = 2,
                GuestsAllowed = 1,
                WeekdayPrice = 199.37m,
                WeekendPrice = 210.59m,
                CleaningFee = 8.83m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3040,
                Address = "864 Ramos Port Apt. 211",
                City = "Moralesmouth",
                State = "OH",
                ZipCode = "88090",
                NumOfBedrooms = 3,
                NumOfBathrooms = 5,
                GuestsAllowed = 9,
                WeekdayPrice = 94.48m,
                WeekendPrice = 153.69m,
                CleaningFee = 16.85m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3041,
                Address = "637 Neal Island Suite 074",
                City = "Lake Tyler",
                State = "RI",
                ZipCode = "28775",
                NumOfBedrooms = 3,
                NumOfBathrooms = 3,
                GuestsAllowed = 14,
                WeekdayPrice = 88.82m,
                WeekendPrice = 196.14m,
                CleaningFee = 6.97m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3042,
                Address = "0811 Smith Canyon Apt. 904",
                City = "Jessicabury",
                State = "WV",
                ZipCode = "75585",
                NumOfBedrooms = 3,
                NumOfBathrooms = 5,
                GuestsAllowed = 2,
                WeekdayPrice = 119.58m,
                WeekendPrice = 123.22m,
                CleaningFee = 18.45m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3043,
                Address = "7562 Fisher Spur",
                City = "Hernandezberg",
                State = "MD",
                ZipCode = "17438",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 2,
                WeekdayPrice = 218.87m,
                WeekendPrice = 283.77m,
                CleaningFee = 19.07m,
                DiscountRate = 0.09m,
                MinNightsForDiscount = 4,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3044,
                Address = "5667 Blair Underpass",
                City = "South Shelby",
                State = "VT",
                ZipCode = "7027",
                NumOfBedrooms = 2,
                NumOfBathrooms = 4,
                GuestsAllowed = 13,
                WeekdayPrice = 76.19m,
                WeekendPrice = 239.76m,
                CleaningFee = 11.37m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3045,
                Address = "6708 Carpenter Overpass Suite 735",
                City = "Bobbyton",
                State = "MI",
                ZipCode = "1008",
                NumOfBedrooms = 7,
                NumOfBathrooms = 7,
                GuestsAllowed = 7,
                WeekdayPrice = 161.17m,
                WeekendPrice = 229.04m,
                CleaningFee = 25.01m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3046,
                Address = "16396 Shawn Junction",
                City = "New Nicolemouth",
                State = "ND",
                ZipCode = "60236",
                NumOfBedrooms = 4,
                NumOfBathrooms = 4,
                GuestsAllowed = 6,
                WeekdayPrice = 106.06m,
                WeekendPrice = 220.69m,
                CleaningFee = 11.82m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3047,
                Address = "4486 Olson Well",
                City = "North Kevin",
                State = "CA",
                ZipCode = "1707",
                NumOfBedrooms = 7,
                NumOfBathrooms = 7,
                GuestsAllowed = 10,
                WeekdayPrice = 151.44m,
                WeekendPrice = 138.96m,
                CleaningFee = 6.72m,
                DiscountRate = 0.18m,
                MinNightsForDiscount = 2,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3048,
                Address = "67771 Christopher Courts Apt. 637",
                City = "Port Ronaldfurt",
                State = "HI",
                ZipCode = "33233",
                NumOfBedrooms = 5,
                NumOfBathrooms = 5,
                GuestsAllowed = 2,
                WeekdayPrice = 102.43m,
                WeekendPrice = 134.28m,
                CleaningFee = 19.81m,
                DiscountRate = 0.15m,
                MinNightsForDiscount = 1,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3049,
                Address = "5561 Bishop Turnpike",
                City = "Lake Kenneth",
                State = "NY",
                ZipCode = "79756",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 11,
                WeekdayPrice = 94.31m,
                WeekendPrice = 259.87m,
                CleaningFee = 22.33m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3050,
                Address = "3019 Gerald Mall Apt. 340",
                City = "Trevinoville",
                State = "SD",
                ZipCode = "36216",
                NumOfBedrooms = 5,
                NumOfBathrooms = 5,
                GuestsAllowed = 1,
                WeekdayPrice = 151.69m,
                WeekendPrice = 263.32m,
                CleaningFee = 13.27m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3051,
                Address = "84331 Leonard Fort Suite 749",
                City = "East Lisa",
                State = "NY",
                ZipCode = "43477",
                NumOfBedrooms = 7,
                NumOfBathrooms = 8,
                GuestsAllowed = 10,
                WeekdayPrice = 204.04m,
                WeekendPrice = 204.28m,
                CleaningFee = 11.07m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3052,
                Address = "62281 Kathy Tunnel",
                City = "Hudsonborough",
                State = "VA",
                ZipCode = "17819",
                NumOfBedrooms = 1,
                NumOfBathrooms = 1,
                GuestsAllowed = 9,
                WeekdayPrice = 165.51m,
                WeekendPrice = 224.19m,
                CleaningFee = 24.26m,
                DiscountRate = 0.12m,
                MinNightsForDiscount = 5,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3053,
                Address = "9927 Christina Burg Suite 774",
                City = "East Angelaburgh",
                State = "NM",
                ZipCode = "97149",
                NumOfBedrooms = 7,
                NumOfBathrooms = 9,
                GuestsAllowed = 6,
                WeekdayPrice = 106.87m,
                WeekendPrice = 121.74m,
                CleaningFee = 5.62m,
                DiscountRate = 0.06m,
                MinNightsForDiscount = 5,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3054,
                Address = "142 Warner View Suite 460",
                City = "North Leslie",
                State = "IA",
                ZipCode = "45480",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 9,
                WeekdayPrice = 212.32m,
                WeekendPrice = 148.76m,
                CleaningFee = 20.20m,
                DiscountRate = 0.12m,
                MinNightsForDiscount = 41,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3055,
                Address = "5240 Berry Centers",
                City = "West Andrew",
                State = "AR",
                ZipCode = "3720",
                NumOfBedrooms = 7,
                NumOfBathrooms = 6,
                GuestsAllowed = 12,
                WeekdayPrice = 164.02m,
                WeekendPrice = 111.01m,
                CleaningFee = 26.21m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Unapproved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3056,
                Address = "51056 Patricia Forge",
                City = "Grahamstad",
                State = "HI",
                ZipCode = "85576",
                NumOfBedrooms = 7,
                NumOfBathrooms = 9,
                GuestsAllowed = 10,
                WeekdayPrice = 117.45m,
                WeekendPrice = 167.53m,
                CleaningFee = 24.75m,
                DiscountRate = 0.17m,
                MinNightsForDiscount = 8,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3057,
                Address = "0648 Malone Port Apt. 662",
                City = "New Devonhaven",
                State = "VA",
                ZipCode = "92199",
                NumOfBedrooms = 6,
                NumOfBathrooms = 5,
                GuestsAllowed = 12,
                WeekdayPrice = 209.47m,
                WeekendPrice = 176.53m,
                CleaningFee = 5.83m,
                DiscountRate = 0.05m,
                MinNightsForDiscount = 3,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3058,
                Address = "23028 Jennifer Meadow Apt. 972",
                City = "West Matthewfurt",
                State = "SC",
                ZipCode = "5261",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 14,
                WeekdayPrice = 153.04m,
                WeekendPrice = 199.10m,
                CleaningFee = 18.62m,
                DiscountRate = 0.13m,
                MinNightsForDiscount = 19,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3059,
                Address = "2738 Martin Terrace Suite 547",
                City = "Smithhaven",
                State = "LA",
                ZipCode = "72649",
                NumOfBedrooms = 1,
                NumOfBathrooms = 1,
                GuestsAllowed = 11,
                WeekdayPrice = 196.56m,
                WeekendPrice = 199.22m,
                CleaningFee = 20.71m,
                DiscountRate = 0.14m,
                MinNightsForDiscount = 4,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3060,
                Address = "984 Stephen Stravenue",
                City = "South Michaelton",
                State = "KY",
                ZipCode = "97488",
                NumOfBedrooms = 4,
                NumOfBathrooms = 6,
                GuestsAllowed = 3,
                WeekdayPrice = 117.03m,
                WeekendPrice = 178.29m,
                CleaningFee = 6.47m,
                DiscountRate = 0.05m,
                MinNightsForDiscount = 4,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3061,
                Address = "98522 Mathis Viaduct Apt. 909",
                City = "West Michael",
                State = "LA",
                ZipCode = "42837",
                NumOfBedrooms = 4,
                NumOfBathrooms = 4,
                GuestsAllowed = 1,
                WeekdayPrice = 133.35m,
                WeekendPrice = 252.79m,
                CleaningFee = 9.15m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3062,
                Address = "620 Ashley Mills Apt. 507",
                City = "Julieborough",
                State = "OH",
                ZipCode = "56059",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 9,
                WeekdayPrice = 171.15m,
                WeekendPrice = 296.05m,
                CleaningFee = 18.26m,
                DiscountRate = 0.21m,
                MinNightsForDiscount = 4,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3063,
                Address = "212 Shelly Roads",
                City = "Fischerview",
                State = "LA",
                ZipCode = "2288",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 10,
                WeekdayPrice = 132.81m,
                WeekendPrice = 163.88m,
                CleaningFee = 7.46m,
                DiscountRate = 0.17m,
                MinNightsForDiscount = 6,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3064,
                Address = "8885 Lee Tunnel Suite 208",
                City = "Port Donna",
                State = "OK",
                ZipCode = "50851",
                NumOfBedrooms = 7,
                NumOfBathrooms = 7,
                GuestsAllowed = 7,
                WeekdayPrice = 228.84m,
                WeekendPrice = 140.73m,
                CleaningFee = 17.13m,
                DiscountRate = 0.23m,
                MinNightsForDiscount = 22,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3065,
                Address = "693 Michael Estate",
                City = "Lake Michael",
                State = "NM",
                ZipCode = "3009",
                NumOfBedrooms = 4,
                NumOfBathrooms = 5,
                GuestsAllowed = 13,
                WeekdayPrice = 155.03m,
                WeekendPrice = 139.83m,
                CleaningFee = 21.05m,
                DiscountRate = 0.09m,
                MinNightsForDiscount = 21,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3066,
                Address = "342 Miller Mission",
                City = "Lake Jennifer",
                State = "NY",
                ZipCode = "92905",
                NumOfBedrooms = 4,
                NumOfBathrooms = 5,
                GuestsAllowed = 1,
                WeekdayPrice = 128.41m,
                WeekendPrice = 249.24m,
                CleaningFee = 6.63m,
                DiscountRate = 0.07m,
                MinNightsForDiscount = 8,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3067,
                Address = "71664 Kim Throughway",
                City = "Chelsealand",
                State = "AK",
                ZipCode = "65056",
                NumOfBedrooms = 6,
                NumOfBathrooms = 8,
                GuestsAllowed = 9,
                WeekdayPrice = 163.68m,
                WeekendPrice = 286.53m,
                CleaningFee = 25.57m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3068,
                Address = "66660 Gomez Port Apt. 945",
                City = "South Thomashaven",
                State = "AZ",
                ZipCode = "11181",
                NumOfBedrooms = 4,
                NumOfBathrooms = 3,
                GuestsAllowed = 2,
                WeekdayPrice = 93.86m,
                WeekendPrice = 137.17m,
                CleaningFee = 28.18m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3069,
                Address = "0131 Williams Ville Apt. 562",
                City = "Richardberg",
                State = "FL",
                ZipCode = "53480",
                NumOfBedrooms = 6,
                NumOfBathrooms = 5,
                GuestsAllowed = 13,
                WeekdayPrice = 86.25m,
                WeekendPrice = 120.61m,
                CleaningFee = 11.39m,
                DiscountRate = 0.17m,
                MinNightsForDiscount = 10,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3070,
                Address = "22708 Madison Spurs",
                City = "Herringstad",
                State = "OR",
                ZipCode = "11353",
                NumOfBedrooms = 6,
                NumOfBathrooms = 7,
                GuestsAllowed = 2,
                WeekdayPrice = 182.46m,
                WeekendPrice = 241.25m,
                CleaningFee = 18.29m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3071,
                Address = "3454 Holmes Motorway",
                City = "Port Rachel",
                State = "FL",
                ZipCode = "5560",
                NumOfBedrooms = 3,
                NumOfBathrooms = 3,
                GuestsAllowed = 1,
                WeekdayPrice = 89.88m,
                WeekendPrice = 123.04m,
                CleaningFee = 19.14m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3072,
                Address = "805 James Turnpike",
                City = "Carrmouth",
                State = "GA",
                ZipCode = "93500",
                NumOfBedrooms = 6,
                NumOfBathrooms = 5,
                GuestsAllowed = 12,
                WeekdayPrice = 81.55m,
                WeekendPrice = 219.86m,
                CleaningFee = 13.38m,
                DiscountRate = 0.22m,
                MinNightsForDiscount = 2,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3073,
                Address = "8081 Smith Trail",
                City = "North Ronaldstad",
                State = "NV",
                ZipCode = "44515",
                NumOfBedrooms = 7,
                NumOfBathrooms = 7,
                GuestsAllowed = 3,
                WeekdayPrice = 130.47m,
                WeekendPrice = 196.09m,
                CleaningFee = 14.53m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3074,
                Address = "125 Ian Crossroad Apt. 593",
                City = "South Deannaport",
                State = "MS",
                ZipCode = "7347",
                NumOfBedrooms = 2,
                NumOfBathrooms = 1,
                GuestsAllowed = 4,
                WeekdayPrice = 148.10m,
                WeekendPrice = 136.82m,
                CleaningFee = 15.57m,
                DiscountRate = 0.22m,
                MinNightsForDiscount = 22,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3075,
                Address = "1607 Munoz River",
                City = "Emilyshire",
                State = "NH",
                ZipCode = "54532",
                NumOfBedrooms = 6,
                NumOfBathrooms = 7,
                GuestsAllowed = 3,
                WeekdayPrice = 147.55m,
                WeekendPrice = 209.77m,
                CleaningFee = 27.65m,
                DiscountRate = 0.09m,
                MinNightsForDiscount = 6,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3076,
                Address = "3615 David Keys Apt. 269",
                City = "West Stephenside",
                State = "UT",
                ZipCode = "65516",
                NumOfBedrooms = 2,
                NumOfBathrooms = 4,
                GuestsAllowed = 3,
                WeekdayPrice = 86.80m,
                WeekendPrice = 126.47m,
                CleaningFee = 17.60m,
                DiscountRate = 0.06m,
                MinNightsForDiscount = 21,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3077,
                Address = "640 Mary Common",
                City = "Michaelville",
                State = "AZ",
                ZipCode = "20721",
                NumOfBedrooms = 3,
                NumOfBathrooms = 4,
                GuestsAllowed = 7,
                WeekdayPrice = 121.75m,
                WeekendPrice = 173.01m,
                CleaningFee = 12.53m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3078,
                Address = "395 Timothy Road",
                City = "Williamsbury",
                State = "LA",
                ZipCode = "43567",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 5,
                WeekdayPrice = 160.23m,
                WeekendPrice = 198.10m,
                CleaningFee = 10.82m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3079,
                Address = "3267 Walter Dam",
                City = "Cunninghamtown",
                State = "OR",
                ZipCode = "1239",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 7,
                WeekdayPrice = 110.64m,
                WeekendPrice = 127.70m,
                CleaningFee = 26.67m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3080,
                Address = "00580 Brandon Creek",
                City = "Port Eric",
                State = "MS",
                ZipCode = "3966",
                NumOfBedrooms = 3,
                NumOfBathrooms = 5,
                GuestsAllowed = 2,
                WeekdayPrice = 227.60m,
                WeekendPrice = 236.71m,
                CleaningFee = 20.22m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3081,
                Address = "325 Amanda Cliffs Apt. 695",
                City = "South Paulabury",
                State = "MS",
                ZipCode = "29996",
                NumOfBedrooms = 6,
                NumOfBathrooms = 6,
                GuestsAllowed = 13,
                WeekdayPrice = 115.37m,
                WeekendPrice = 135.59m,
                CleaningFee = 29.80m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3082,
                Address = "40956 Amanda Walk Apt. 260",
                City = "Simonfurt",
                State = "CT",
                ZipCode = "93980",
                NumOfBedrooms = 4,
                NumOfBathrooms = 4,
                GuestsAllowed = 5,
                WeekdayPrice = 93.35m,
                WeekendPrice = 271.49m,
                CleaningFee = 8.54m,
                DiscountRate = 0.18m,
                MinNightsForDiscount = 6,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3083,
                Address = "25762 Gill Creek Suite 525",
                City = "Mccoyton",
                State = "KS",
                ZipCode = "23687",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 5,
                WeekdayPrice = 171.37m,
                WeekendPrice = 247.15m,
                CleaningFee = 17.22m,
                DiscountRate = 0.21m,
                MinNightsForDiscount = 8,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3084,
                Address = "6048 Johnson Loop Suite 635",
                City = "East Daniel",
                State = "GA",
                ZipCode = "4593",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 8,
                WeekdayPrice = 95.59m,
                WeekendPrice = 299.60m,
                CleaningFee = 24.30m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3085,
                Address = "1168 Gary Fords Apt. 308",
                City = "Port Trevor",
                State = "RI",
                ZipCode = "96954",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 11,
                WeekdayPrice = 194.84m,
                WeekendPrice = 278.17m,
                CleaningFee = 5.88m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3086,
                Address = "164 Matthew Parkway Suite 826",
                City = "Jimmyfurt",
                State = "MS",
                ZipCode = "62271",
                NumOfBedrooms = 6,
                NumOfBathrooms = 8,
                GuestsAllowed = 8,
                WeekdayPrice = 112.03m,
                WeekendPrice = 100.08m,
                CleaningFee = 28.82m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3087,
                Address = "1220 Heidi Rue Apt. 998",
                City = "West Haleyburgh",
                State = "CO",
                ZipCode = "5222",
                NumOfBedrooms = 5,
                NumOfBathrooms = 4,
                GuestsAllowed = 1,
                WeekdayPrice = 127.97m,
                WeekendPrice = 182.77m,
                CleaningFee = 13.02m,
                DiscountRate = 0.17m,
                MinNightsForDiscount = 37,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3088,
                Address = "751 Wood Square Suite 732",
                City = "Port Melissaburgh",
                State = "SD",
                ZipCode = "22365",
                NumOfBedrooms = 7,
                NumOfBathrooms = 7,
                GuestsAllowed = 13,
                WeekdayPrice = 120.07m,
                WeekendPrice = 186.01m,
                CleaningFee = 26.71m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3089,
                Address = "376 Smith Dale Suite 279",
                City = "South Sarahland",
                State = "OR",
                ZipCode = "53609",
                NumOfBedrooms = 2,
                NumOfBathrooms = 2,
                GuestsAllowed = 9,
                WeekdayPrice = 137.96m,
                WeekendPrice = 122.31m,
                CleaningFee = 26.29m,
                DiscountRate = 0.10m,
                MinNightsForDiscount = 29,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3090,
                Address = "79148 Pierce Lock Suite 423",
                City = "Erikberg",
                State = "CA",
                ZipCode = "9478",
                NumOfBedrooms = 3,
                NumOfBathrooms = 5,
                GuestsAllowed = 6,
                WeekdayPrice = 226.57m,
                WeekendPrice = 234.61m,
                CleaningFee = 16.41m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3091,
                Address = "147 Lisa Hill Apt. 512",
                City = "Port Elizabethshire",
                State = "ID",
                ZipCode = "1425",
                NumOfBedrooms = 4,
                NumOfBathrooms = 6,
                GuestsAllowed = 10,
                WeekdayPrice = 95.73m,
                WeekendPrice = 145.15m,
                CleaningFee = 9.93m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3092,
                Address = "971 Hansen Well Suite 103",
                City = "South Mary",
                State = "KY",
                ZipCode = "29941",
                NumOfBedrooms = 6,
                NumOfBathrooms = 8,
                GuestsAllowed = 4,
                WeekdayPrice = 161.68m,
                WeekendPrice = 145.72m,
                CleaningFee = 24.36m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3093,
                Address = "511 Berry Fork Suite 623",
                City = "Sharonfort",
                State = "WY",
                ZipCode = "47577",
                NumOfBedrooms = 4,
                NumOfBathrooms = 5,
                GuestsAllowed = 3,
                WeekdayPrice = 183.81m,
                WeekendPrice = 260.18m,
                CleaningFee = 7.46m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Unapproved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3094,
                Address = "65873 Chen Knolls",
                City = "Ramirezfurt",
                State = "WI",
                ZipCode = "94134",
                NumOfBedrooms = 4,
                NumOfBathrooms = 3,
                GuestsAllowed = 14,
                WeekdayPrice = 215.38m,
                WeekendPrice = 117.17m,
                CleaningFee = 24.31m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3095,
                Address = "8799 Emma Parkway Suite 735",
                City = "North Thomasfurt",
                State = "IN",
                ZipCode = "57039",
                NumOfBedrooms = 3,
                NumOfBathrooms = 5,
                GuestsAllowed = 11,
                WeekdayPrice = 145.51m,
                WeekendPrice = 242.21m,
                CleaningFee = 11.89m,
                DiscountRate = 0.10m,
                MinNightsForDiscount = 41,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3096,
                Address = "30068 David View Apt. 173",
                City = "New Peggychester",
                State = "ND",
                ZipCode = "23718",
                NumOfBedrooms = 4,
                NumOfBathrooms = 6,
                GuestsAllowed = 7,
                WeekdayPrice = 142.76m,
                WeekendPrice = 161.21m,
                CleaningFee = 20.92m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3097,
                Address = "298 Johnathan Cove Apt. 402",
                City = "South Jamie",
                State = "MD",
                ZipCode = "26932",
                NumOfBedrooms = 6,
                NumOfBathrooms = 7,
                GuestsAllowed = 13,
                WeekdayPrice = 170.07m,
                WeekendPrice = 176.37m,
                CleaningFee = 8.54m,
                DiscountRate = 0.09m,
                MinNightsForDiscount = 17,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3098,
                Address = "171 Harrison Motorway",
                City = "Davidview",
                State = "CO",
                ZipCode = "74554",
                NumOfBedrooms = 6,
                NumOfBathrooms = 8,
                GuestsAllowed = 10,
                WeekdayPrice = 145.08m,
                WeekendPrice = 234.81m,
                CleaningFee = 26.14m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3099,
                Address = "3576 Sergio Avenue",
                City = "Benjaminmouth",
                State = "NE",
                ZipCode = "32097",
                NumOfBedrooms = 1,
                NumOfBathrooms = 1,
                GuestsAllowed = 1,
                WeekdayPrice = 111.73m,
                WeekendPrice = 260.62m,
                CleaningFee = 15.89m,
                DiscountRate = 0.24m,
                MinNightsForDiscount = 9,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3100,
                Address = "37457 Tanya Pike Apt. 348",
                City = "North Ericton",
                State = "RI",
                ZipCode = "21519",
                NumOfBedrooms = 2,
                NumOfBathrooms = 1,
                GuestsAllowed = 13,
                WeekdayPrice = 70.63m,
                WeekendPrice = 214.62m,
                CleaningFee = 5.29m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3101,
                Address = "3673 Peter Turnpike Suite 835",
                City = "New Sandra",
                State = "PA",
                ZipCode = "76875",
                NumOfBedrooms = 4,
                NumOfBathrooms = 4,
                GuestsAllowed = 6,
                WeekdayPrice = 229.03m,
                WeekendPrice = 172.79m,
                CleaningFee = 14.05m,
                DiscountRate = 0.14m,
                MinNightsForDiscount = 12,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3102,
                Address = "939 Johnson Oval Suite 830",
                City = "North Dennismouth",
                State = "TX",
                ZipCode = "80451",
                NumOfBedrooms = 3,
                NumOfBathrooms = 5,
                GuestsAllowed = 6,
                WeekdayPrice = 169.34m,
                WeekendPrice = 133.53m,
                CleaningFee = 18.06m,
                DiscountRate = 0.25m,
                MinNightsForDiscount = 28,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3103,
                Address = "645 Jennings Estates",
                City = "Angelastad",
                State = "NV",
                ZipCode = "51726",
                NumOfBedrooms = 2,
                NumOfBathrooms = 3,
                GuestsAllowed = 4,
                WeekdayPrice = 155.52m,
                WeekendPrice = 109.44m,
                CleaningFee = 8.28m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3104,
                Address = "1231 Stephanie Lock Suite 835",
                City = "North Richardland",
                State = "MT",
                ZipCode = "77240",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 5,
                WeekdayPrice = 180.20m,
                WeekendPrice = 182.33m,
                CleaningFee = 17.78m,
                DiscountRate = 0.13m,
                MinNightsForDiscount = 13,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3105,
                Address = "302 Parker Plains Apt. 197",
                City = "East Robertstad",
                State = "CO",
                ZipCode = "98152",
                NumOfBedrooms = 3,
                NumOfBathrooms = 2,
                GuestsAllowed = 1,
                WeekdayPrice = 212.86m,
                WeekendPrice = 212.70m,
                CleaningFee = 6.82m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3106,
                Address = "098 Hernandez Green",
                City = "New Sergiobury",
                State = "MS",
                ZipCode = "98277",
                NumOfBedrooms = 4,
                NumOfBathrooms = 6,
                GuestsAllowed = 8,
                WeekdayPrice = 188.71m,
                WeekendPrice = 262.30m,
                CleaningFee = 21.88m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3107,
                Address = "94102 Sims Port Suite 187",
                City = "Florestown",
                State = "NE",
                ZipCode = "80082",
                NumOfBedrooms = 4,
                NumOfBathrooms = 4,
                GuestsAllowed = 8,
                WeekdayPrice = 83.34m,
                WeekendPrice = 128.05m,
                CleaningFee = 11.29m,
                DiscountRate = 0.21m,
                MinNightsForDiscount = 8,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3108,
                Address = "01630 Baker Crescent",
                City = "Kellyborough",
                State = "ND",
                ZipCode = "71531",
                NumOfBedrooms = 1,
                NumOfBathrooms = 1,
                GuestsAllowed = 4,
                WeekdayPrice = 204.02m,
                WeekendPrice = 125.27m,
                CleaningFee = 21.15m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3109,
                Address = "70452 Forbes Courts",
                City = "Mosesland",
                State = "OK",
                ZipCode = "14157",
                NumOfBedrooms = 4,
                NumOfBathrooms = 3,
                GuestsAllowed = 9,
                WeekdayPrice = 90.98m,
                WeekendPrice = 172.10m,
                CleaningFee = 18.09m,
                DiscountRate = 0.22m,
                MinNightsForDiscount = 11,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3110,
                Address = "0835 Angela Station",
                City = "East Heather",
                State = "MO",
                ZipCode = "26899",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 9,
                WeekdayPrice = 158.64m,
                WeekendPrice = 299.91m,
                CleaningFee = 23.09m,
                DiscountRate = 0.12m,
                MinNightsForDiscount = 22,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3111,
                Address = "2458 Jason Village Suite 248",
                City = "North Donnamouth",
                State = "VT",
                ZipCode = "42872",
                NumOfBedrooms = 2,
                NumOfBathrooms = 4,
                GuestsAllowed = 4,
                WeekdayPrice = 107.97m,
                WeekendPrice = 189.30m,
                CleaningFee = 9.05m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3112,
                Address = "1243 Grimes Corners",
                City = "Shawchester",
                State = "CO",
                ZipCode = "78301",
                NumOfBedrooms = 4,
                NumOfBathrooms = 3,
                GuestsAllowed = 2,
                WeekdayPrice = 214.14m,
                WeekendPrice = 193.24m,
                CleaningFee = 26.10m,
                DiscountRate = 0.06m,
                MinNightsForDiscount = 21,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3113,
                Address = "558 Williams Station",
                City = "Port Pamela",
                State = "DC",
                ZipCode = "34523",
                NumOfBedrooms = 6,
                NumOfBathrooms = 7,
                GuestsAllowed = 4,
                WeekdayPrice = 106.30m,
                WeekendPrice = 192.46m,
                CleaningFee = 17.59m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3114,
                Address = "4934 Lozano Place Suite 716",
                City = "Gavinton",
                State = "VT",
                ZipCode = "63064",
                NumOfBedrooms = 5,
                NumOfBathrooms = 6,
                GuestsAllowed = 6,
                WeekdayPrice = 116.99m,
                WeekendPrice = 257.37m,
                CleaningFee = 5.63m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3115,
                Address = "41227 Patricia Lake",
                City = "Martinezbury",
                State = "LA",
                ZipCode = "35700",
                NumOfBedrooms = 2,
                NumOfBathrooms = 1,
                GuestsAllowed = 3,
                WeekdayPrice = 203.03m,
                WeekendPrice = 108.28m,
                CleaningFee = 11.35m,
                DiscountRate = 0.10m,
                MinNightsForDiscount = 4,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3116,
                Address = "028 Harris Drive Apt. 422",
                City = "Amyburgh",
                State = "VA",
                ZipCode = "55206",
                NumOfBedrooms = 2,
                NumOfBathrooms = 2,
                GuestsAllowed = 14,
                WeekdayPrice = 163.30m,
                WeekendPrice = 262.77m,
                CleaningFee = 13.74m,
                DiscountRate = 0.16m,
                MinNightsForDiscount = 12,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3117,
                Address = "06268 Lewis Place Suite 121",
                City = "Port Patriciatown",
                State = "IA",
                ZipCode = "98240",
                NumOfBedrooms = 3,
                NumOfBathrooms = 2,
                GuestsAllowed = 4,
                WeekdayPrice = 156.25m,
                WeekendPrice = 108.52m,
                CleaningFee = 23.66m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3118,
                Address = "5641 Brenda Streets Apt. 008",
                City = "Lake Seanmouth",
                State = "WI",
                ZipCode = "87205",
                NumOfBedrooms = 5,
                NumOfBathrooms = 6,
                GuestsAllowed = 12,
                WeekdayPrice = 178.27m,
                WeekendPrice = 153.42m,
                CleaningFee = 24.69m,
                DiscountRate = 0.06m,
                MinNightsForDiscount = 23,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3119,
                Address = "92555 Shaw Spurs Suite 207",
                City = "New Randy",
                State = "ME",
                ZipCode = "58221",
                NumOfBedrooms = 7,
                NumOfBathrooms = 8,
                GuestsAllowed = 13,
                WeekdayPrice = 92.51m,
                WeekendPrice = 184.92m,
                CleaningFee = 12.82m,
                DiscountRate = 0.12m,
                MinNightsForDiscount = 3,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3120,
                Address = "559 Foster Locks Suite 933",
                City = "Robinsonhaven",
                State = "NY",
                ZipCode = "18885",
                NumOfBedrooms = 6,
                NumOfBathrooms = 6,
                GuestsAllowed = 6,
                WeekdayPrice = 224.62m,
                WeekendPrice = 225.85m,
                CleaningFee = 17.90m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3121,
                Address = "4647 Kristine Fields Suite 710",
                City = "New Dakota",
                State = "WY",
                ZipCode = "638",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 10,
                WeekdayPrice = 112.61m,
                WeekendPrice = 174.02m,
                CleaningFee = 17.48m,
                DiscountRate = 0.08m,
                MinNightsForDiscount = 5,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3122,
                Address = "92594 Emily Shoals",
                City = "North Cathyburgh",
                State = "ME",
                ZipCode = "31451",
                NumOfBedrooms = 6,
                NumOfBathrooms = 5,
                GuestsAllowed = 1,
                WeekdayPrice = 189.98m,
                WeekendPrice = 119.06m,
                CleaningFee = 25.11m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3123,
                Address = "551 Casey Squares Apt. 209",
                City = "Michaelborough",
                State = "MS",
                ZipCode = "26297",
                NumOfBedrooms = 1,
                NumOfBathrooms = 1,
                GuestsAllowed = 6,
                WeekdayPrice = 72.03m,
                WeekendPrice = 114.73m,
                CleaningFee = 18.38m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3124,
                Address = "2998 Willis Wall",
                City = "North Brian",
                State = "PA",
                ZipCode = "4610",
                NumOfBedrooms = 3,
                NumOfBathrooms = 4,
                GuestsAllowed = 3,
                WeekdayPrice = 216.21m,
                WeekendPrice = 144.51m,
                CleaningFee = 10.81m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3125,
                Address = "164 Schultz Road",
                City = "Lake Bryan",
                State = "MD",
                ZipCode = "86618",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 13,
                WeekdayPrice = 132.69m,
                WeekendPrice = 233.90m,
                CleaningFee = 15.80m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3126,
                Address = "9541 Brock Estate Apt. 848",
                City = "Franklinchester",
                State = "GA",
                ZipCode = "80124",
                NumOfBedrooms = 2,
                NumOfBathrooms = 1,
                GuestsAllowed = 9,
                WeekdayPrice = 220.97m,
                WeekendPrice = 285.05m,
                CleaningFee = 20.98m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3127,
                Address = "588 Alan Rest",
                City = "Port Stephanieville",
                State = "MS",
                ZipCode = "63590",
                NumOfBedrooms = 6,
                NumOfBathrooms = 6,
                GuestsAllowed = 12,
                WeekdayPrice = 224.98m,
                WeekendPrice = 180.86m,
                CleaningFee = 11.91m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3128,
                Address = "216 Brandon Loop Apt. 096",
                City = "New Jessica",
                State = "MT",
                ZipCode = "53548",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 12,
                WeekdayPrice = 221.98m,
                WeekendPrice = 239.97m,
                CleaningFee = 9.24m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3129,
                Address = "782 Dawn Radial",
                City = "Port Christopher",
                State = "LA",
                ZipCode = "35611",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 1,
                WeekdayPrice = 76.56m,
                WeekendPrice = 297.25m,
                CleaningFee = 20.42m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3130,
                Address = "008 Nancy Route Suite 228",
                City = "North Stephanie",
                State = "WA",
                ZipCode = "42879",
                NumOfBedrooms = 2,
                NumOfBathrooms = 3,
                GuestsAllowed = 3,
                WeekdayPrice = 128.71m,
                WeekendPrice = 129.36m,
                CleaningFee = 23.76m,
                DiscountRate = 0.08m,
                MinNightsForDiscount = 3,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3131,
                Address = "115 Jon Isle Suite 788",
                City = "North Lesliefurt",
                State = "MO",
                ZipCode = "71569",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 9,
                WeekdayPrice = 114.21m,
                WeekendPrice = 210.63m,
                CleaningFee = 21.08m,
                DiscountRate = 0.21m,
                MinNightsForDiscount = 42,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3132,
                Address = "132 Poole Pass Suite 212",
                City = "North Patrick",
                State = "DE",
                ZipCode = "87566",
                NumOfBedrooms = 5,
                NumOfBathrooms = 6,
                GuestsAllowed = 11,
                WeekdayPrice = 146.82m,
                WeekendPrice = 280.37m,
                CleaningFee = 26.78m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3133,
                Address = "457 Vargas Island Suite 853",
                City = "Lake Patrickstad",
                State = "WY",
                ZipCode = "67652",
                NumOfBedrooms = 4,
                NumOfBathrooms = 3,
                GuestsAllowed = 1,
                WeekdayPrice = 134.72m,
                WeekendPrice = 249.39m,
                CleaningFee = 19.19m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3134,
                Address = "1569 Amy Path",
                City = "North Ashleyton",
                State = "HI",
                ZipCode = "45184",
                NumOfBedrooms = 7,
                NumOfBathrooms = 8,
                GuestsAllowed = 7,
                WeekdayPrice = 111.60m,
                WeekendPrice = 111.23m,
                CleaningFee = 13.48m,
                DiscountRate = 0.21m,
                MinNightsForDiscount = 5,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3135,
                Address = "0375 Sandra Trace Suite 826",
                City = "Gailshire",
                State = "IL",
                ZipCode = "4078",
                NumOfBedrooms = 5,
                NumOfBathrooms = 6,
                GuestsAllowed = 3,
                WeekdayPrice = 89.00m,
                WeekendPrice = 168.47m,
                CleaningFee = 14.93m,
                DiscountRate = 0.21m,
                MinNightsForDiscount = 36,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3136,
                Address = "759 Good Port",
                City = "New Russell",
                State = "MN",
                ZipCode = "50437",
                NumOfBedrooms = 5,
                NumOfBathrooms = 5,
                GuestsAllowed = 6,
                WeekdayPrice = 208.64m,
                WeekendPrice = 208.35m,
                CleaningFee = 7.09m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3137,
                Address = "3895 Allen Junction",
                City = "West John",
                State = "WV",
                ZipCode = "34147",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 3,
                WeekdayPrice = 172.51m,
                WeekendPrice = 195.41m,
                CleaningFee = 21.53m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3138,
                Address = "7329 Jacobs Station",
                City = "New Tylerborough",
                State = "MS",
                ZipCode = "36340",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 8,
                WeekdayPrice = 163.15m,
                WeekendPrice = 146.12m,
                CleaningFee = 18.98m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3139,
                Address = "5003 Cassandra Estates Suite 148",
                City = "Haleychester",
                State = "MD",
                ZipCode = "88806",
                NumOfBedrooms = 7,
                NumOfBathrooms = 7,
                GuestsAllowed = 9,
                WeekdayPrice = 81.50m,
                WeekendPrice = 161.49m,
                CleaningFee = 16.41m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3140,
                Address = "10524 Parker Mall Suite 531",
                City = "Port Courtneyhaven",
                State = "TN",
                ZipCode = "76853",
                NumOfBedrooms = 5,
                NumOfBathrooms = 7,
                GuestsAllowed = 13,
                WeekdayPrice = 177.94m,
                WeekendPrice = 120.73m,
                CleaningFee = 9.50m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3141,
                Address = "300 Madison Stream",
                City = "Christophershire",
                State = "MO",
                ZipCode = "93533",
                NumOfBedrooms = 3,
                NumOfBathrooms = 4,
                GuestsAllowed = 6,
                WeekdayPrice = 121.01m,
                WeekendPrice = 187.08m,
                CleaningFee = 16.48m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3142,
                Address = "4229 Derrick Wells",
                City = "West Tyler",
                State = "FL",
                ZipCode = "96763",
                NumOfBedrooms = 2,
                NumOfBathrooms = 4,
                GuestsAllowed = 6,
                WeekdayPrice = 199.68m,
                WeekendPrice = 241.45m,
                CleaningFee = 25.94m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3143,
                Address = "26239 Michael Shoals",
                City = "Gregoryview",
                State = "VA",
                ZipCode = "92174",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 9,
                WeekdayPrice = 162.01m,
                WeekendPrice = 111.91m,
                CleaningFee = 14.35m,
                DiscountRate = 0.10m,
                MinNightsForDiscount = 29,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3144,
                Address = "302 Joy Spring Apt. 622",
                City = "Ryanhaven",
                State = "IN",
                ZipCode = "88294",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 12,
                WeekdayPrice = 173.36m,
                WeekendPrice = 163.73m,
                CleaningFee = 25.35m,
                DiscountRate = 0.06m,
                MinNightsForDiscount = 32,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3145,
                Address = "734 Craig Overpass Suite 589",
                City = "Jefferyside",
                State = "CA",
                ZipCode = "23464",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 8,
                WeekdayPrice = 216.10m,
                WeekendPrice = 287.28m,
                CleaningFee = 22.20m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3146,
                Address = "272 Green Street",
                City = "Port Lacey",
                State = "CA",
                ZipCode = "35243",
                NumOfBedrooms = 4,
                NumOfBathrooms = 3,
                GuestsAllowed = 7,
                WeekdayPrice = 211.51m,
                WeekendPrice = 247.34m,
                CleaningFee = 11.73m,
                DiscountRate = 0.13m,
                MinNightsForDiscount = 6,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3147,
                Address = "8056 Dunn Trail Apt. 049",
                City = "Blackshire",
                State = "IL",
                ZipCode = "61935",
                NumOfBedrooms = 5,
                NumOfBathrooms = 6,
                GuestsAllowed = 2,
                WeekdayPrice = 111.40m,
                WeekendPrice = 189.08m,
                CleaningFee = 19.58m,
                DiscountRate = 0.07m,
                MinNightsForDiscount = 9,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3148,
                Address = "86187 Antonio Fort",
                City = "North Carmen",
                State = "CA",
                ZipCode = "72324",
                NumOfBedrooms = 7,
                NumOfBathrooms = 9,
                GuestsAllowed = 7,
                WeekdayPrice = 150.69m,
                WeekendPrice = 109.87m,
                CleaningFee = 13.30m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3149,
                Address = "71318 Cassandra Plaza",
                City = "Burkeview",
                State = "NJ",
                ZipCode = "84393",
                NumOfBedrooms = 7,
                NumOfBathrooms = 7,
                GuestsAllowed = 10,
                WeekdayPrice = 184.21m,
                WeekendPrice = 227.55m,
                CleaningFee = 19.52m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3150,
                Address = "5303 Lewis Springs",
                City = "Port Adrian",
                State = "NH",
                ZipCode = "62346",
                NumOfBedrooms = 2,
                NumOfBathrooms = 1,
                GuestsAllowed = 2,
                WeekdayPrice = 204.67m,
                WeekendPrice = 207.51m,
                CleaningFee = 26.36m,
                DiscountRate = 0.22m,
                MinNightsForDiscount = 44,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3151,
                Address = "465 Wiley Corners Apt. 759",
                City = "East Michellechester",
                State = "IA",
                ZipCode = "2837",
                NumOfBedrooms = 6,
                NumOfBathrooms = 5,
                GuestsAllowed = 11,
                WeekdayPrice = 129.14m,
                WeekendPrice = 213.84m,
                CleaningFee = 12.81m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3152,
                Address = "521 Flores Stream",
                City = "West Rebeccaborough",
                State = "LA",
                ZipCode = "68847",
                NumOfBedrooms = 3,
                NumOfBathrooms = 5,
                GuestsAllowed = 3,
                WeekdayPrice = 77.06m,
                WeekendPrice = 254.37m,
                CleaningFee = 6.03m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3153,
                Address = "0271 Soto Drives Apt. 975",
                City = "New Edgar",
                State = "NE",
                ZipCode = "35218",
                NumOfBedrooms = 4,
                NumOfBathrooms = 5,
                GuestsAllowed = 9,
                WeekdayPrice = 179.91m,
                WeekendPrice = 233.17m,
                CleaningFee = 11.04m,
                DiscountRate = 0.18m,
                MinNightsForDiscount = 32,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3154,
                Address = "27862 Kent Mountains",
                City = "Lake Michaelville",
                State = "NM",
                ZipCode = "32697",
                NumOfBedrooms = 6,
                NumOfBathrooms = 5,
                GuestsAllowed = 14,
                WeekdayPrice = 90.54m,
                WeekendPrice = 153.38m,
                CleaningFee = 6.91m,
                DiscountRate = 0.18m,
                MinNightsForDiscount = 30,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3155,
                Address = "917 Mclaughlin Glens",
                City = "Martinville",
                State = "OR",
                ZipCode = "95889",
                NumOfBedrooms = 7,
                NumOfBathrooms = 6,
                GuestsAllowed = 2,
                WeekdayPrice = 225.59m,
                WeekendPrice = 226.89m,
                CleaningFee = 28.99m,
                DiscountRate = 0.12m,
                MinNightsForDiscount = 15,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3156,
                Address = "3032 Michelle Drives",
                City = "North Daniel",
                State = "KY",
                ZipCode = "82153",
                NumOfBedrooms = 3,
                NumOfBathrooms = 4,
                GuestsAllowed = 13,
                WeekdayPrice = 203.25m,
                WeekendPrice = 157.15m,
                CleaningFee = 15.68m,
                DiscountRate = 0.23m,
                MinNightsForDiscount = 9,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3157,
                Address = "601 Maria Mission Apt. 554",
                City = "Myerstown",
                State = "SD",
                ZipCode = "32202",
                NumOfBedrooms = 7,
                NumOfBathrooms = 9,
                GuestsAllowed = 9,
                WeekdayPrice = 223.27m,
                WeekendPrice = 269.55m,
                CleaningFee = 11.35m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3158,
                Address = "238 Shawn Well",
                City = "Port Johnshire",
                State = "OH",
                ZipCode = "17431",
                NumOfBedrooms = 7,
                NumOfBathrooms = 8,
                GuestsAllowed = 14,
                WeekdayPrice = 173.63m,
                WeekendPrice = 112.64m,
                CleaningFee = 6.38m,
                DiscountRate = 0.06m,
                MinNightsForDiscount = 13,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3159,
                Address = "41743 Berger Inlet Apt. 527",
                City = "South Tammymouth",
                State = "SC",
                ZipCode = "37901",
                NumOfBedrooms = 7,
                NumOfBathrooms = 9,
                GuestsAllowed = 9,
                WeekdayPrice = 176.23m,
                WeekendPrice = 163.20m,
                CleaningFee = 14.77m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3160,
                Address = "9983 Mary Grove Apt. 643",
                City = "Beardview",
                State = "MO",
                ZipCode = "17895",
                NumOfBedrooms = 7,
                NumOfBathrooms = 6,
                GuestsAllowed = 9,
                WeekdayPrice = 219.53m,
                WeekendPrice = 209.33m,
                CleaningFee = 24.51m,
                DiscountRate = 0.10m,
                MinNightsForDiscount = 16,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3161,
                Address = "03541 Ryan Islands Apt. 562",
                City = "East Michaelfort",
                State = "HI",
                ZipCode = "90576",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 10,
                WeekdayPrice = 126.25m,
                WeekendPrice = 269.63m,
                CleaningFee = 8.27m,
                DiscountRate = 0.16m,
                MinNightsForDiscount = 8,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3162,
                Address = "6591 Angela Mission Apt. 108",
                City = "Penabury",
                State = "SC",
                ZipCode = "94980",
                NumOfBedrooms = 5,
                NumOfBathrooms = 6,
                GuestsAllowed = 14,
                WeekdayPrice = 143.98m,
                WeekendPrice = 286.86m,
                CleaningFee = 20.48m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3163,
                Address = "492 Ramirez Crossing",
                City = "Aaronberg",
                State = "CO",
                ZipCode = "44974",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 10,
                WeekdayPrice = 121.91m,
                WeekendPrice = 144.60m,
                CleaningFee = 10.12m,
                DiscountRate = 0.22m,
                MinNightsForDiscount = 8,
                PetFriendly = false,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3164,
                Address = "35974 Sharon Locks Apt. 101",
                City = "Jennyport",
                State = "DE",
                ZipCode = "66170",
                NumOfBedrooms = 7,
                NumOfBathrooms = 9,
                GuestsAllowed = 1,
                WeekdayPrice = 137.80m,
                WeekendPrice = 114.46m,
                CleaningFee = 17.74m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3165,
                Address = "89403 Gabriella Mills",
                City = "East Steven",
                State = "UT",
                ZipCode = "22495",
                NumOfBedrooms = 3,
                NumOfBathrooms = 4,
                GuestsAllowed = 11,
                WeekdayPrice = 128.63m,
                WeekendPrice = 155.10m,
                CleaningFee = 23.05m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3166,
                Address = "601 Kyle Roads",
                City = "Clarkfurt",
                State = "NH",
                ZipCode = "85059",
                NumOfBedrooms = 4,
                NumOfBathrooms = 5,
                GuestsAllowed = 4,
                WeekdayPrice = 209.11m,
                WeekendPrice = 284.39m,
                CleaningFee = 6.25m,
                DiscountRate = 0.14m,
                MinNightsForDiscount = 6,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3167,
                Address = "60969 Justin Passage Suite 774",
                City = "Joshuaburgh",
                State = "IN",
                ZipCode = "61092",
                NumOfBedrooms = 1,
                NumOfBathrooms = 1,
                GuestsAllowed = 7,
                WeekdayPrice = 128.59m,
                WeekendPrice = 121.00m,
                CleaningFee = 19.36m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3168,
                Address = "7943 Tina Mount",
                City = "East Lisa",
                State = "PA",
                ZipCode = "43986",
                NumOfBedrooms = 4,
                NumOfBathrooms = 3,
                GuestsAllowed = 14,
                WeekdayPrice = 122.88m,
                WeekendPrice = 104.47m,
                CleaningFee = 25.31m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3169,
                Address = "6775 James Ford",
                City = "South Victorialand",
                State = "NC",
                ZipCode = "91397",
                NumOfBedrooms = 1,
                NumOfBathrooms = 3,
                GuestsAllowed = 9,
                WeekdayPrice = 211.24m,
                WeekendPrice = 275.50m,
                CleaningFee = 15.74m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3170,
                Address = "431 Johnson Neck Suite 039",
                City = "Mariechester",
                State = "VT",
                ZipCode = "67849",
                NumOfBedrooms = 1,
                NumOfBathrooms = 1,
                GuestsAllowed = 9,
                WeekdayPrice = 124.65m,
                WeekendPrice = 126.24m,
                CleaningFee = 24.30m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3171,
                Address = "15666 Justin Locks",
                City = "Lake Ryanport",
                State = "NM",
                ZipCode = "20687",
                NumOfBedrooms = 6,
                NumOfBathrooms = 6,
                GuestsAllowed = 3,
                WeekdayPrice = 70.11m,
                WeekendPrice = 112.05m,
                CleaningFee = 27.45m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3172,
                Address = "9947 Torres Viaduct Apt. 506",
                City = "Benjaminport",
                State = "TX",
                ZipCode = "30222",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 11,
                WeekdayPrice = 174.87m,
                WeekendPrice = 152.09m,
                CleaningFee = 18.44m,
                DiscountRate = 0.08m,
                MinNightsForDiscount = 8,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3173,
                Address = "20866 Keith Mill",
                City = "Susanton",
                State = "NJ",
                ZipCode = "21190",
                NumOfBedrooms = 2,
                NumOfBathrooms = 4,
                GuestsAllowed = 10,
                WeekdayPrice = 96.80m,
                WeekendPrice = 174.06m,
                CleaningFee = 28.15m,
                DiscountRate = 0.10m,
                MinNightsForDiscount = 21,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3174,
                Address = "04374 Nicholas Cliff Suite 001",
                City = "Adrianport",
                State = "AL",
                ZipCode = "4838",
                NumOfBedrooms = 1,
                NumOfBathrooms = 1,
                GuestsAllowed = 10,
                WeekdayPrice = 205.01m,
                WeekendPrice = 108.24m,
                CleaningFee = 6.56m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3175,
                Address = "271 Andrew Summit",
                City = "Port Craig",
                State = "CA",
                ZipCode = "80130",
                NumOfBedrooms = 7,
                NumOfBathrooms = 6,
                GuestsAllowed = 7,
                WeekdayPrice = 197.52m,
                WeekendPrice = 148.39m,
                CleaningFee = 20.55m,
                DiscountRate = 0.14m,
                MinNightsForDiscount = 27,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Unapproved,
                User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3176,
                Address = "17611 Robbins Mission",
                City = "New Curtis",
                State = "MN",
                ZipCode = "96166",
                NumOfBedrooms = 3,
                NumOfBathrooms = 3,
                GuestsAllowed = 9,
                WeekdayPrice = 219.69m,
                WeekendPrice = 286.13m,
                CleaningFee = 10.64m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3177,
                Address = "80831 Kemp Pines",
                City = "Annashire",
                State = "MO",
                ZipCode = "40702",
                NumOfBedrooms = 1,
                NumOfBathrooms = 2,
                GuestsAllowed = 7,
                WeekdayPrice = 91.26m,
                WeekendPrice = 123.93m,
                CleaningFee = 19.36m,
                DiscountRate = 0.23m,
                MinNightsForDiscount = 19,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3178,
                Address = "96545 Smith Alley",
                City = "West Joy",
                State = "IL",
                ZipCode = "86023",
                NumOfBedrooms = 6,
                NumOfBathrooms = 8,
                GuestsAllowed = 7,
                WeekdayPrice = 132.54m,
                WeekendPrice = 254.38m,
                CleaningFee = 14.83m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3179,
                Address = "6146 Johnson Isle",
                City = "South Arthur",
                State = "MT",
                ZipCode = "70897",
                NumOfBedrooms = 2,
                NumOfBathrooms = 4,
                GuestsAllowed = 1,
                WeekdayPrice = 227.96m,
                WeekendPrice = 228.04m,
                CleaningFee = 6.99m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3180,
                Address = "0415 Smith Springs",
                City = "Jeremyburgh",
                State = "MN",
                ZipCode = "69154",
                NumOfBedrooms = 4,
                NumOfBathrooms = 4,
                GuestsAllowed = 3,
                WeekdayPrice = 140.93m,
                WeekendPrice = 228.81m,
                CleaningFee = 29.74m,
                DiscountRate = 0.15m,
                MinNightsForDiscount = 21,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3181,
                Address = "3999 Ricky Via",
                City = "West Adamburgh",
                State = "HI",
                ZipCode = "53524",
                NumOfBedrooms = 7,
                NumOfBathrooms = 6,
                GuestsAllowed = 6,
                WeekdayPrice = 137.35m,
                WeekendPrice = 255.43m,
                CleaningFee = 16.62m,
                DiscountRate = 0.14m,
                MinNightsForDiscount = 21,
                PetFriendly = true,
                HasParking = true,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3182,
                Address = "83787 Stuart Key",
                City = "Davetown",
                State = "MN",
                ZipCode = "24886",
                NumOfBedrooms = 7,
                NumOfBathrooms = 6,
                GuestsAllowed = 4,
                WeekdayPrice = 172.99m,
                WeekendPrice = 146.75m,
                CleaningFee = 26.24m,
                DiscountRate = 0.23m,
                MinNightsForDiscount = 6,
                PetFriendly = true,
                HasParking = false,
                PropertyStatus = PropertyStatus.Unapproved,
                User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            AllProperties.Add(new Property
            {
                PropertyNumber = 3183,
                Address = "690 Christina Park",
                City = "Toddburgh",
                State = "TX",
                ZipCode = "56713",
                NumOfBedrooms = 3,
                NumOfBathrooms = 5,
                GuestsAllowed = 1,
                WeekdayPrice = 188.53m,
                WeekendPrice = 157.96m,
                CleaningFee = 6.69m,
                DiscountRate = 0.00m,
                MinNightsForDiscount = 0,
                PetFriendly = false,
                HasParking = false,
                PropertyStatus = PropertyStatus.Approved,
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu"),
                Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin")
            });
            // Debugging variables
            int intPropertyNumber = 0;

            try
            {
                foreach (Property seedProperty in AllProperties)
                {
                    // Update debugging variables
                    intPropertyNumber = seedProperty.PropertyNumber;

                    // Check if property exists
                    Property dbProperty = db.Properties
                        .FirstOrDefault(p => p.PropertyNumber == intPropertyNumber);

                    if (dbProperty == null) // Add if not in the database
                    {
                        db.Properties.Add(seedProperty);
                        db.SaveChanges();
                    }
                    else // Update if it exists
                    {
                        dbProperty.Address = seedProperty.Address;
                        dbProperty.City = seedProperty.City;
                        dbProperty.State = seedProperty.State;
                        dbProperty.ZipCode = seedProperty.ZipCode;
                        dbProperty.NumOfBedrooms = seedProperty.NumOfBedrooms;
                        dbProperty.NumOfBathrooms = seedProperty.NumOfBathrooms;
                        dbProperty.GuestsAllowed = seedProperty.GuestsAllowed;
                        dbProperty.WeekdayPrice = seedProperty.WeekdayPrice;
                        dbProperty.WeekendPrice = seedProperty.WeekendPrice;
                        dbProperty.CleaningFee = seedProperty.CleaningFee;
                        dbProperty.DiscountRate = seedProperty.DiscountRate;
                        dbProperty.MinNightsForDiscount = seedProperty.MinNightsForDiscount;
                        dbProperty.PetFriendly = seedProperty.PetFriendly;
                        dbProperty.HasParking = seedProperty.HasParking;
                        dbProperty.PropertyStatus = seedProperty.PropertyStatus;
                        dbProperty.Category = seedProperty.Category;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error with detailed message
                StringBuilder msg = new StringBuilder();
                msg.Append("Error adding or updating property: ");
                msg.Append(intPropertyNumber);
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
