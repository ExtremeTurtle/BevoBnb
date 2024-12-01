using System;
using System.ComponentModel.DataAnnotations;

namespace Group7FinalProject.Models
{
    public enum Filter { GreaterThan, LessThan }

    public class SearchViewModel
    {
        // Search by City
        [Display(Name = "City:")]
        public string SearchCity { get; set; }

        // Search by State
        [Display(Name = "State:")]
        public string SearchState { get; set; }

        // Search by Guest Rating
        [Display(Name = "Guest Rating:")]
        [Range(1.0, 5.0, ErrorMessage = "Rating must be between 1.0 and 5.0")]
        public decimal? SearchGuestRating { get; set; }

        [Display(Name = "Guest Rating Filter:")]
        public Filter FilterGuestRating { get; set; }

        // Search by Daily Price
        [Display(Name = "Daily Price:")]
        public decimal? SearchDailyPrice { get; set; }

        [Display(Name = "Daily Price Filter:")]
        public Filter FilterDailyPrice { get; set; }

        // Search by Category
        [Display(Name = "Category:")]
        public int? SelectedCategoryID { get; set; }

        // Search by Number of Bedrooms
        [Display(Name = "Number of Bedrooms:")]
        public int? SearchBedrooms { get; set; }

        // Search by Number of Bathrooms
        [Display(Name = "Number of Bathrooms:")]
        public int? SearchBathrooms { get; set; }

        // Pets Allowed
        [Display(Name = "Pets Allowed:")]
        public bool? SearchPetsAllowed { get; set; }

        // Free Parking
        [Display(Name = "Free Parking:")]
        public bool? SearchFreeParking { get; set; }

        // Search by Check-In Date
        [Display(Name = "Check-In Date:")]
        [DataType(DataType.Date)]
        public DateTime? SearchCheckInDate { get; set; }

        // Search by Check-Out Date
        [Display(Name = "Check-Out Date:")]
        [DataType(DataType.Date)]
        public DateTime? SearchCheckOutDate { get; set; }

        // Constructor to set defaults
        public SearchViewModel()
        {
            SearchCity = "";
            SearchState = "";
            SearchGuestRating = null;
            FilterGuestRating = Filter.GreaterThan;
            SearchDailyPrice = null;
            FilterDailyPrice = Filter.LessThan;
            SelectedCategoryID = null;
            SearchBedrooms = null;
            SearchBathrooms = null;
            SearchPetsAllowed = null;
            SearchFreeParking = null;
            SearchCheckInDate = null;
            SearchCheckOutDate = null;
        }
    }
}
