using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group7FinalProject.Models
{
    //Enum for the status of a reservation
    public enum ReservationStatus {Valid, Cancelled, Unconfirmed}
    public class Reservation
    {
        //Constant Tax Rate of 7%
        private const Decimal TAX_RATE = 7.00m;

        //Creates the primary key for Reservation table
        public Int32 ReservationID { get; set; }

        [Display(Name = "Confirmation Number")]
        public Int32 ConfirmationNumber { get; set; }

        [Required(ErrorMessage = "Check-in date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Check-in Date")]
        public DateTime CheckIn {  get; set; }

        [Required(ErrorMessage = "Check-out date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Check-out Date")]
        public DateTime CheckOut { get; set; }

        [Required(ErrorMessage = "Number of guests is required")]
        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 0.")]

        [Display(Name = "Number of guests")]
        //The number of guests staying
        public Int32 NumOfGuests { get; set; }

        [Display(Name = "Weekday price")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]

        [DisplayFormat(DataFormatString = "{0:C}")]
        //Stores weekday price of reservation
        public Decimal WeekdayPrice { get; set; }

        [Display(Name = "Weekend price")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]

        [DisplayFormat(DataFormatString = "{0:C}")]
        //Stores weekend price of reservation
        public Decimal WeekendPrice { get; set; }

        [Display(Name = "Cleaning Fee")]
        [Range(0, int.MaxValue, ErrorMessage = "The value must be non-negative.")]

        [DisplayFormat(DataFormatString = "{0:C}")]
        //Stores cleaning fee for reservation
        public Decimal CleaningFee {  get; set; }

        //Stores discount rate for reservation
        [Display(Name = "Discount Rate")]
        public Decimal DiscountRate { get; set; }

        [Display(Name = "Reservation Status")]
        //Stores enum for Status of Reservation
        public ReservationStatus ReservationStatus { get; set; }


        //Many side of One-To-Many relationship with Customer
        public AppUser? User { get; set; }

        //Many side of One-To-Many relationship with Property
        public Property? Property { get; set; }

        //Many side of One-To-Many relationship with Cart
        public Cart? Cart { get; set; }


        // Calculated values
        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Weekday Total")]
        public decimal WeekdayTotal { get; private set; }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Weekend Total")]
        public decimal WeekendTotal { get; private set; }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Discount Amount")]
        public decimal DiscountAmount { get; private set; }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Stay Price")]
        public decimal StayPrice { get; private set; }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Subtotal")]
        public decimal SubTotal { get; private set; }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Tax")]
        public decimal Tax { get; private set; }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Total Price")]
        public decimal TotalPrice { get; private set; }

        // Method to calculate totals
        public void CalcTotals()
        {
            // Calculate the number of days
            int totalDays = (CheckOut - CheckIn).Days;

            // Count weekdays and weekends
            int weekdayCount = 0, weekendCount = 0;
            for (DateTime date = CheckIn; date < CheckOut; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekendCount++;
                }
                else
                {
                    weekdayCount++;
                }
            }

            // Calculate weekday and weekend totals
            WeekdayTotal = weekdayCount * WeekdayPrice;
            WeekendTotal = weekendCount * WeekendPrice;

            // Calculate discount
            if (totalDays >= Property?.MinNightsForDiscount)
            {
                DiscountAmount = (WeekdayTotal + WeekendTotal) * DiscountRate;
            }
            else
            {
                DiscountAmount = 0;
            }

            // Calculate stay price
            StayPrice = (WeekdayTotal + WeekendTotal) - DiscountAmount;

            // Calculate subtotal
            SubTotal = StayPrice + CleaningFee;

            // Calculate tax
            Tax = SubTotal * (TAX_RATE/100);

            // Calculate total price (reservation total)
            TotalPrice = SubTotal + Tax;
        }

    }


}
