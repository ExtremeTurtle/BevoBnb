namespace Group7FinalProject.Models
{
    public class Unavailability
    {
        public int UnavailabilityID { get; set; } // Primary Key
        public DateTime UnavailableDate { get; set; } // Specific date of unavailability

       

        // Navigation Property
        public Property Property { get; set; }
    }
}