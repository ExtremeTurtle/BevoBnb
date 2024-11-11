namespace Group7FinalProject.Models
{
    //Enum for the status of a reservation
    public enum ReservationStatus { Upcoming, Canceled, Past}
    public class Reservation
    {
        //Constant Tax Rate of 7%
        private const Decimal TAX_RATE = 7.00m;

        //Creates the primary key for Reservation table
        public Int32 ReservationID { get; set; }

        public Int32 ConfirmationNumber { get; set; }

        public DateTime CheckIn {  get; set; }
        public DateTime CheckOut { get; set; }

        //The number of guests staying
        public Int32 NumOfGuests { get; set; }

        //Stores weekday price of reservation
        public Decimal WeekdayPrice { get; set; }

        //Stores weekend price of reservation
        public Decimal WeekendPrice { get; set; }

        //Stores cleaning fee for reservation
        public Decimal CleaningFee {  get; set; }
        
        //Stores discount rate for reservation
        public Decimal DiscountRate { get; set; }

        //Stores enum for Status of Reservation
        public ReservationStatus ReservationStatus { get; set; }


        //Many side of One-To-Many relationship with Customer
        public AppUser User { get; set; }

        //Many side of One-To-Many relationship with Property
        public Property Property { get; set; }

    }
}
