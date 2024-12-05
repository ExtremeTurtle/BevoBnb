using System.ComponentModel.DataAnnotations;

namespace Group7FinalProject.Models
{
    public enum PropertyStatus { Unapproved, Approved }
    public enum Active { Active, Inactive }
    public class Property
    {
        public Int32 PropertyID { get; set; } // Primary Key

        [Display(Name = "Property Number:")]
        public Int32 PropertyNumber { get; set; } // Unique Identifier

        [Display(Name = "Street Address:")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "City:")]
        [RegularExpression(@"^[a-zA-Z\s\-]+$", ErrorMessage = "City can only contain letters, spaces, and hyphens.")]
        [Required]
        public string City { get; set; }

        [Display(Name = "State:")]
        [RegularExpression(@"^[A-Z]{2}$", ErrorMessage = "State must be a valid two-letter abbreviation (e.g., TX, CA, NY).")]

        [Required]
        public string State { get; set; }

        [Display(Name = "Zip Code:")]
        [Required]
        public string ZipCode { get; set; }

        [Display(Name = "Number of Bedrooms:")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]

        [Required]
        public Int32 NumOfBedrooms { get; set; }

        [Display(Name = "Number of Bathrooms:")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]

        [Required]
        public Int32 NumOfBathrooms { get; set; }

        [Display(Name = "Guest Limit:")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]

        [Required]
        public Int32 GuestsAllowed { get; set; }

        [Display(Name = "Weekday price:")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]

        [Required]

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekdayPrice { get; set; }

        [Display(Name = "Weekend price:")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekendPrice { get; set; }

        [Display(Name = "Cleaning Fee:")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal CleaningFee { get; set; }

        [Display(Name = "Discount Rate:")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]

        public Decimal DiscountRate { get; set; }

        [Display(Name = "Minimum nights for discount:")]
        [Range(0, 100, ErrorMessage = "Discount rate must be between 0% and 100%.")]

        public int MinNightsForDiscount {  get; set; }

        [Display(Name = "Pet Friendly:")]
        [Required]
        public Boolean PetFriendly { get; set; }

        [Display(Name = "Parking Offered:")]
        [Required]
        public Boolean HasParking { get; set; }

        [Display(Name = "Property Status:")]
        [Required]
        public PropertyStatus PropertyStatus { get; set; }

        [Display(Name = "Active Status:")]
        [Required]
        public Active ActiveStatus { get; set; }


        // Navigation Properties
        public AppUser? User { get; set; } // The host user

        public Category? Category { get; set; } // The category of the property

        public List<Reservation>? Reservations { get; set; } // Reservations for this property

        public List<Review> Reviews { get; set; } // Reviews for this property

        public List<Unavailability> Unavailabilities { get; set; } // Unavailable dates

        public Property()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }
            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }
            if (Unavailabilities == null)
            {
                Unavailabilities = new List<Unavailability>();
            }

        }
    }
}