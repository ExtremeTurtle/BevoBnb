using System.ComponentModel.DataAnnotations;

namespace Group7FinalProject.Models
{
    public class Unavailability
    {
        public int UnavailabilityID { get; set; } // Primary Key

        [DataType(DataType.Date)]

        [Display(Name = "Unavailability Date")]
        public DateTime UnavailableDate { get; set; } // Specific date of unavailability

       

        // Navigation Property
        public Property Property { get; set; }
    }
}