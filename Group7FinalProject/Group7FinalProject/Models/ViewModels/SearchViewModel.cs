using System;
using System.ComponentModel.DataAnnotations;

namespace Group7FinalProject.Models
{
    public enum Filter { GreaterThan, LessThan }

    public class SearchViewModel : IValidatableObject
    {
        [Display(Name = "City:")]
        public string? SearchCity { get; set; }

        [Display(Name = "State:")]
        public string? SearchState { get; set; }

        [Display(Name = "Zip:")]
        public string? SearchZip { get; set; }

        //fix
        [Display(Name = "Guest Rating:")]
        [Range(minimum: 1, maximum: 5, ErrorMessage = "Rating must be between 0.0 and 5.0")]
        public Decimal? SearchGuestRating { get; set; }
        public Filter? FilterGuestRating { get; set; }

        [Display(Name = "Weekday Price:")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]
        public Decimal? SearchWeekdayPrice { get; set; }
        public Filter? FilterWeekdayPrice { get; set; }

        [Display(Name = "Weekend Price:")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]
        public Decimal? SearchWeekendPrice { get; set; }
        public Filter? FilterWeekendPrice { get; set; }

        [Display(Name = "Category:")]
        public int? SelectedCategory { get; set; }

        [Display(Name = "Number of Guests:")]
        public int? SearchGuests { get; set; }

        [Display(Name = "Number of Bedrooms:")]
        public int? SearchBedrooms { get; set; }

        [Display(Name = "Number of Bathrooms:")]
        public int? SearchBathrooms { get; set; }

        [Display(Name = "Pets Allowed:")]
        public bool? SearchPetsAllowed { get; set; }

        [Display(Name = "Free Parking:")]
        public bool? SearchFreeParking { get; set; }

        [Display(Name = "Check-In Date:")]
        [DataType(DataType.Date)]
        public DateTime? SearchCheckInDate { get; set; }

        [Display(Name = "Check-Out Date:")]
        [DataType(DataType.Date)]
        public DateTime? SearchCheckOutDate { get; set; }


        // Custom validation for Check-In and Check-Out Dates
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (SearchCheckInDate.HasValue && SearchCheckOutDate.HasValue &&
                SearchCheckInDate > SearchCheckOutDate)
            {
                yield return new ValidationResult("Check-In Date cannot be later than Check-Out Date.",
                    new[] { nameof(SearchCheckInDate), nameof(SearchCheckOutDate) });
            }
        }
    }
}
