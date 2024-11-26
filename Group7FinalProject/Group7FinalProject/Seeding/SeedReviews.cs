
using Group7FinalProject.DAL;
using Group7FinalProject.Models;
using System.Text;

namespace Group7FinalProject.Seeding
{


    public static class SeedReviews
    {
        public static void SeedAllReviews(AppDbContext db)
        {
            // Define all review records
            List<Review> AllReviews = new List<Review>();

            AllReviews.Add(new Review
            {
                Rating = 4,
                ReviewText = " ",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3127),
                User = db.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 3,
                ReviewText = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator.",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3085),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 4,
                ReviewText = "",
                HostComments = "The customer did not provide a valid reason for this rating.",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3161),
                User = db.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 2,
                ReviewText = " ",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3127),
                User = db.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 3,
                ReviewText = "Nebraska was... interesting",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                User = db.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 1,
                ReviewText = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN",
                HostComments = "It is not my fault there was corn. It was not my corn!",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 1,
                ReviewText = "Worst. Stay. Ever. Never using BevoBnB again",
                HostComments = "BevoBnB is the best",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                User = db.Users.FirstOrDefault(u => u.Email == "ra@aoo.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 5,
                ReviewText = " ",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 2,
                ReviewText = " ",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3133),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 1,
                ReviewText = "It was SO hard to book this place. Who coded this site anyway? ;)",
                HostComments = "The website was coded by students so the owner should not be penalized!",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 4,
                ReviewText = " ",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3067),
                User = db.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 5,
                ReviewText = "This place rocked!",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                User = db.Users.FirstOrDefault(u => u.Email == "ra@aoo.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 4,
                ReviewText = " ",
                HostComments = "I do not understand this.",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 4,
                ReviewText = " ",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3133),
                User = db.Users.FirstOrDefault(u => u.Email == "lamemartin.Martin@aool.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 1,
                ReviewText = "There were 1...5...22 roaches? I lost count.",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 1,
                ReviewText = " ",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3085),
                User = db.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 4,
                ReviewText = "I LOVED the place! Had a nice view of the mountains",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3087),
                User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 5,
                ReviewText = " ",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3087),
                User = db.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 5,
                ReviewText = "My stay was amazing! Saved my marriage",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3127),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 2,
                ReviewText = " ",
                HostComments = "Why??",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3133),
                User = db.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com")
            });

            AllReviews.Add(new Review
            {
                Rating = 2,
                ReviewText = "My wife's attitude was the only thing rougher than the sand at the nearby beaches",
                HostComments = "",
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3161),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            // Debugging variables
            int intReviewID = 0;

            try
            {
                foreach (Review seedReview in AllReviews)
                {
                    // Update debugging variables
                    intReviewID = seedReview.ReviewID;

                    // Check if review exists
                    Review dbReview = db.Reviews
                        .FirstOrDefault(r => r.Property.PropertyNumber == seedReview.Property.PropertyNumber &&
                                             r.User.Email == seedReview.User.Email);

                    if (dbReview == null) // Add if not in the database
                    {
                        db.Reviews.Add(seedReview);
                        db.SaveChanges();
                    }
                    else // Update if it exists
                    {
                        dbReview.Rating = seedReview.Rating;
                        dbReview.ReviewText = seedReview.ReviewText;
                        dbReview.HostComments = seedReview.HostComments;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error with detailed message
                StringBuilder msg = new StringBuilder();
                msg.Append("Error adding or updating review: ");
                msg.Append(intReviewID);
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}

