namespace Group7FinalProject.Models
{
    public class Property
    {
        public Int32 PropertyID { get; set; } // Primary Key

        public Int32 PropertyNumber { get; set; } // Unique Identifier

        public Int32 NumOfBedrooms { get; set; }

        public Int32 NumOfBathrooms { get; set; }

        public Int32 GuestsAllowed { get; set; }

        public Decimal WeekdayPrice { get; set; }

        public Decimal WeekendPrice { get; set; }

        public Decimal CleaningFee { get; set; }
        public Decimal DiscountRate { get; set; }


        public Boolean PetFriendly { get; set; }

        public Boolean HasParking { get; set; }

        // Foreign Keys
        public Int32 HostID { get; set; }

        public Int32 CategoryID { get; set; }

        // Navigation Properties
        public AppUser User { get; set; } // The host user

        public Category Category { get; set; } // The category of the property

        public ICollection<Reservation> Reservations { get; set; } // Reservations for this property

        public ICollection<Review> Reviews { get; set; } // Reviews for this property

        public ICollection<Unavailability> Unavailabilities { get; set; } // Unavailable dates
    }
}