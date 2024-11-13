using System.ComponentModel.DataAnnotations;

namespace Group7FinalProject.Models
{
    public class Property
    {
        public Int32 PropertyID { get; set; } // Primary Key

        [Display(Name = "Property Number:")]
        public Int32 PropertyNumber { get; set; } // Unique Identifier

        [Display(Name = "Street Address:")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "APT #:")]
        public string AddressApt { get; set; }

        [Display(Name = "City:")]
        [Required]
        public string City { get; set; }

        [Display(Name = "State:")]
        [Required]
        public string State { get; set; }

        [Display(Name = "Zip Code:")]
        [Required]
        public string ZipCode { get; set; }

        [Display(Name = "Number of Bedrooms:")]
        [Required]
        public Int32 NumOfBedrooms { get; set; }

        [Display(Name = "Number of Bathrooms:")]
        [Required]
        public Int32 NumOfBathrooms { get; set; }

        [Display(Name = "Guest Limit:")]
        [Required]
        public Int32 GuestsAllowed { get; set; }

        [Display(Name = "Weekday price:")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekdayPrice { get; set; }

        [Display(Name = "Weekend price:")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekendPrice { get; set; }

        [Display(Name = "Cleaning Fee:")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal CleaningFee { get; set; }

        [Display(Name = "Discount Rate:")]
        public Decimal DiscountRate { get; set; }

        [Display(Name = "Minimum nights for discount:")]
        public int MinNightsForDiscount {  get; set; }

        [Display(Name = "Pet Friendly:")]
        [Required]
        public Boolean PetFriendly { get; set; }

        [Display(Name = "Parking Offered:")]
        [Required]
        public Boolean HasParking { get; set; }

        [Display(Name = "Property Status:")]
        [Required]
        public Boolean PropertyStatus { get; set; }


        // Navigation Properties
        public AppUser User { get; set; } // The host user

        [Required]
        public Category Category { get; set; } // The category of the property

        public List<Reservation> Reservations { get; set; } // Reservations for this property

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