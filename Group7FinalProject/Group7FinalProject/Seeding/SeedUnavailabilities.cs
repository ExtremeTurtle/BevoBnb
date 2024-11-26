using Group7FinalProject.DAL;
using Group7FinalProject.Models;
using System.Text;

namespace Group7FinalProject.Seeding
{
    public static class SeedUnavailabilities
    {

        public static void SeedAllUnavailabilities(AppDbContext db)
        {
            // Define all unavailability records
            List<Unavailability> AllUnavailabilities = new List<Unavailability>
    {
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3009),
            UnavailableDate = new DateTime(2024, 12, 4),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3009),
            UnavailableDate = new DateTime(2024, 12, 5),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3172),
            UnavailableDate = new DateTime(2024, 12, 30),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3172),
            UnavailableDate = new DateTime(2024, 12, 31),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3172),
            UnavailableDate = new DateTime(2025, 1, 1),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3113),
            UnavailableDate = new DateTime(2024, 12, 5),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3113),
            UnavailableDate = new DateTime(2024, 12, 6),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3113),
            UnavailableDate = new DateTime(2024, 12, 7),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3099),
            UnavailableDate = new DateTime(2024, 12, 29),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3099),
            UnavailableDate = new DateTime(2024, 12, 30),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3099),
            UnavailableDate = new DateTime(2024, 12, 31),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3099),
            UnavailableDate = new DateTime(2025, 1, 1),
        },
        new Unavailability
        {
            Property = db.Properties.FirstOrDefault(c => c.PropertyNumber == 3100),
            UnavailableDate = new DateTime(2024, 12, 31),
        },
    };

            // Debugging variables
            int intPropertyNumber = 0;
            DateTime dtUnavailableDate = DateTime.MinValue;

            try
            {
                foreach (Unavailability seedUnavailability in AllUnavailabilities)
                {
                    // Update debugging variables
                    intPropertyNumber = seedUnavailability.Property?.PropertyNumber ?? 0;
                    dtUnavailableDate = seedUnavailability.UnavailableDate;

                    // Check if unavailability exists
                    Unavailability dbUnavailability = db.Unavailabilities
                        .FirstOrDefault(u => u.Property.PropertyNumber == intPropertyNumber &&
                                             u.UnavailableDate == dtUnavailableDate);

                    if (dbUnavailability == null) // Add if not in the database
                    {
                        db.Unavailabilities.Add(seedUnavailability);
                        db.SaveChanges();
                    }
                    else // Update if it exists
                    {
                        dbUnavailability.UnavailableDate = seedUnavailability.UnavailableDate;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error with detailed message
                StringBuilder msg = new StringBuilder();
                msg.Append("Error adding unavailability for property: ");
                msg.Append(intPropertyNumber);
                msg.Append(" on date: ");
                msg.Append(dtUnavailableDate.ToString("yyyy-MM-dd"));
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}

