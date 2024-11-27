using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Number of guests")]
        //The number of guests staying
        public Int32 NumOfGuests { get; set; }

        [Display(Name = "Weekday price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        //Stores weekday price of reservation
        public Decimal WeekdayPrice { get; set; }

        [Display(Name = "Weekend price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        //Stores weekend price of reservation
        public Decimal WeekendPrice { get; set; }

        [Display(Name = "Cleaning Fee")]
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

    }
}
