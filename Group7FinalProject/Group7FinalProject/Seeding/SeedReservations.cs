
using Group7FinalProject.DAL;
using Group7FinalProject.Models;
using System.Text;

namespace Group7FinalProject.Seeding
{
    public static class SeedReservations
    {
        public static void SeedAllReservations(AppDbContext db)
        {
            // Define all reservation records
            List<Reservation> AllReservations = new List<Reservation>();

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21900,
                CheckIn = new DateTime(2024, 11, 01),
                CheckOut = new DateTime(2024, 11, 03),
                NumOfGuests = 1,
                WeekdayPrice = 134.72m,
                WeekendPrice = 249.39m,
                CleaningFee = 19.19m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3133),
                User = db.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21901,
                CheckIn = new DateTime(2024, 11, 04),
                CheckOut = new DateTime(2024, 11, 06),
                NumOfGuests = 2,
                WeekdayPrice = 204.67m,
                WeekendPrice = 207.51m,
                CleaningFee = 26.36m,
                DiscountRate = 0.22m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3150),
                User = db.Users.FirstOrDefault(u => u.Email == "luce_chuck@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21901,
                CheckIn = new DateTime(2024, 11, 05),
                CheckOut = new DateTime(2024, 11, 10),
                NumOfGuests = 14,
                WeekdayPrice = 163.30m,
                WeekendPrice = 262.77m,
                CleaningFee = 13.74m,
                DiscountRate = 0.16m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3116),
                User = db.Users.FirstOrDefault(u => u.Email == "luce_chuck@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21902,
                CheckIn = new DateTime(2024, 11, 07),
                CheckOut = new DateTime(2024, 11, 12),
                NumOfGuests = 1,
                WeekdayPrice = 134.72m,
                WeekendPrice = 249.39m,
                CleaningFee = 19.19m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3133),
                User = db.Users.FirstOrDefault(u => u.Email == "lamemartin.Martin@aool.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21903,
                CheckIn = new DateTime(2024, 11, 06),
                CheckOut = new DateTime(2024, 11, 18),
                NumOfGuests = 9,
                WeekdayPrice = 163.68m,
                WeekendPrice = 286.53m,
                CleaningFee = 25.57m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3067),
                User = db.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21904,
                CheckIn = new DateTime(2024, 11, 07),
                CheckOut = new DateTime(2024, 11, 15),
                NumOfGuests = 3,
                WeekdayPrice = 147.55m,
                WeekendPrice = 209.77m,
                CleaningFee = 27.65m,
                DiscountRate = 0.09m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3075),
                User = db.Users.FirstOrDefault(u => u.Email == "liz@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21905,
                CheckIn = new DateTime(2024, 11, 17),
                CheckOut = new DateTime(2024, 11, 22),
                NumOfGuests = 12,
                WeekdayPrice = 224.98m,
                WeekendPrice = 180.86m,
                CleaningFee = 11.91m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3127),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21906,
                CheckIn = new DateTime(2024, 11, 20),
                CheckOut = new DateTime(2024, 11, 27),
                NumOfGuests = 1,
                WeekdayPrice = 134.72m,
                WeekendPrice = 249.39m,
                CleaningFee = 19.19m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3133),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21907,
                CheckIn = new DateTime(2024, 11, 23),
                CheckOut = new DateTime(2024, 12, 01),
                NumOfGuests = 5,
                WeekdayPrice = 93.35m,
                WeekendPrice = 271.49m,
                CleaningFee = 8.54m,
                DiscountRate = 0.18m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3082),
                User = db.Users.FirstOrDefault(u => u.Email == "elowe@netscrape.net")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21908,
                CheckIn = new DateTime(2024, 11, 24),
                CheckOut = new DateTime(2024, 12, 04),
                NumOfGuests = 11,
                WeekdayPrice = 174.87m,
                WeekendPrice = 152.09m,
                CleaningFee = 18.44m,
                DiscountRate = 0.08m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3172),
                User = db.Users.FirstOrDefault(u => u.Email == "victoria@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21909,
                CheckIn = new DateTime(2024, 11, 29),
                CheckOut = new DateTime(2024, 12, 18),
                NumOfGuests = 10,
                WeekdayPrice = 117.45m,
                WeekendPrice = 167.53m,
                CleaningFee = 24.75m,
                DiscountRate = 0.17m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3056),
                User = db.Users.FirstOrDefault(u => u.Email == "wjhearniii@umch.edu")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21910,
                CheckIn = new DateTime(2024, 11, 28),
                CheckOut = new DateTime(2024, 12, 07),
                NumOfGuests = 13,
                WeekdayPrice = 155.03m,
                WeekendPrice = 139.83m,
                CleaningFee = 21.05m,
                DiscountRate = 0.09m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21911,
                CheckIn = new DateTime(2024, 11, 01),
                CheckOut = new DateTime(2024, 11, 29),
                NumOfGuests = 9,
                WeekdayPrice = 163.68m,
                WeekendPrice = 286.53m,
                CleaningFee = 25.57m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3067),
                User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21912,
                CheckIn = new DateTime(2024, 11, 15),
                CheckOut = new DateTime(2024, 12, 01),
                NumOfGuests = 14,
                WeekdayPrice = 215.38m,
                WeekendPrice = 117.17m,
                CleaningFee = 24.31m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3094),
                User = db.Users.FirstOrDefault(u => u.Email == "wendy@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21913,
                CheckIn = new DateTime(2024, 11, 05),
                CheckOut = new DateTime(2024, 12, 03),
                NumOfGuests = 7,
                WeekdayPrice = 150.69m,
                WeekendPrice = 109.87m,
                CleaningFee = 13.30m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3148),
                User = db.Users.FirstOrDefault(u => u.Email == "444444.Dave@aool.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21914,
                CheckIn = new DateTime(2024, 11, 01),
                CheckOut = new DateTime(2024, 11, 22),
                NumOfGuests = 12,
                WeekdayPrice = 224.98m,
                WeekendPrice = 180.86m,
                CleaningFee = 11.91m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3127),
                User = db.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21915,
                CheckIn = new DateTime(2024, 12, 08),
                CheckOut = new DateTime(2024, 12, 10),
                NumOfGuests = 11,
                WeekdayPrice = 194.84m,
                WeekendPrice = 278.17m,
                CleaningFee = 5.88m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3085),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21916,
                CheckIn = new DateTime(2024, 12, 09),
                CheckOut = new DateTime(2024, 12, 11),
                NumOfGuests = 3,
                WeekdayPrice = 140.93m,
                WeekendPrice = 228.81m,
                CleaningFee = 29.74m,
                DiscountRate = 0.15m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3180),
                User = db.Users.FirstOrDefault(u => u.Email == "hicks43@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21917,
                CheckIn = new DateTime(2024, 12, 01),
                CheckOut = new DateTime(2024, 12, 05),
                NumOfGuests = 10,
                WeekdayPrice = 126.25m,
                WeekendPrice = 269.63m,
                CleaningFee = 8.27m,
                DiscountRate = 0.16m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3161),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21918,
                CheckIn = new DateTime(2024, 12, 01),
                CheckOut = new DateTime(2024, 12, 04),
                NumOfGuests = 11,
                WeekdayPrice = 194.84m,
                WeekendPrice = 278.17m,
                CleaningFee = 5.88m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3085),
                User = db.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21919,
                CheckIn = new DateTime(2024, 12, 08),
                CheckOut = new DateTime(2024, 12, 09),
                NumOfGuests = 12,
                WeekdayPrice = 112.62m,
                WeekendPrice = 165.32m,
                CleaningFee = 24.26m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3021),
                User = db.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21919,
                CheckIn = new DateTime(2024, 12, 08),
                CheckOut = new DateTime(2024, 12, 11),
                NumOfGuests = 10,
                WeekdayPrice = 205.01m,
                WeekendPrice = 108.24m,
                CleaningFee = 6.56m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3174),
                User = db.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21919,
                CheckIn = new DateTime(2024, 12, 08),
                CheckOut = new DateTime(2024, 12, 10),
                NumOfGuests = 12,
                WeekdayPrice = 170.25m,
                WeekendPrice = 100.37m,
                CleaningFee = 18.64m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3005),
                User = db.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21919,
                CheckIn = new DateTime(2024, 11, 22),
                CheckOut = new DateTime(2024, 12, 05),
                NumOfGuests = 10,
                WeekdayPrice = 126.25m,
                WeekendPrice = 269.63m,
                CleaningFee = 8.27m,
                DiscountRate = 0.16m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3161),
                User = db.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21920,
                CheckIn = new DateTime(2024, 12, 08),
                CheckOut = new DateTime(2024, 12, 12),
                NumOfGuests = 1,
                WeekdayPrice = 127.97m,
                WeekendPrice = 182.77m,
                CleaningFee = 13.02m,
                DiscountRate = 0.17m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3087),
                User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21921,
                CheckIn = new DateTime(2024, 12, 08),
                CheckOut = new DateTime(2024, 12, 12),
                NumOfGuests = 8,
                WeekdayPrice = 83.34m,
                WeekendPrice = 128.05m,
                CleaningFee = 11.29m,
                DiscountRate = 0.21m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                User = db.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21921,
                CheckIn = new DateTime(2024, 12, 06),
                CheckOut = new DateTime(2024, 12, 15),
                NumOfGuests = 10,
                WeekdayPrice = 204.04m,
                WeekendPrice = 204.28m,
                CleaningFee = 11.07m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3051),
                User = db.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21923,
                CheckIn = new DateTime(2024, 12, 07),
                CheckOut = new DateTime(2024, 12, 31),
                NumOfGuests = 3,
                WeekdayPrice = 130.47m,
                WeekendPrice = 196.09m,
                CleaningFee = 14.53m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3073),
                User = db.Users.FirstOrDefault(u => u.Email == "jeff@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21923,
                CheckIn = new DateTime(2024, 12, 11),
                CheckOut = new DateTime(2024, 12, 24),
                NumOfGuests = 13,
                WeekdayPrice = 170.07m,
                WeekendPrice = 176.37m,
                CleaningFee = 8.54m,
                DiscountRate = 0.09m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3097),
                User = db.Users.FirstOrDefault(u => u.Email == "cmiller@mapster.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21924,
                CheckIn = new DateTime(2024, 11, 22),
                CheckOut = new DateTime(2024, 11, 29),
                NumOfGuests = 1,
                WeekdayPrice = 127.97m,
                WeekendPrice = 182.77m,
                CleaningFee = 13.02m,
                DiscountRate = 0.17m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3087),
                User = db.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21925,
                CheckIn = new DateTime(2024, 12, 16),
                CheckOut = new DateTime(2024, 12, 31),
                NumOfGuests = 5,
                WeekdayPrice = 104.05m,
                WeekendPrice = 158.42m,
                CleaningFee = 5.36m,
                DiscountRate = 0.23m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3038),
                User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21925,
                CheckIn = new DateTime(2024, 11, 20),
                CheckOut = new DateTime(2024, 12, 22),
                NumOfGuests = 8,
                WeekdayPrice = 83.34m,
                WeekendPrice = 128.05m,
                CleaningFee = 11.29m,
                DiscountRate = 0.21m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21925,
                CheckIn = new DateTime(2024, 12, 22),
                CheckOut = new DateTime(2024, 12, 28),
                NumOfGuests = 4,
                WeekdayPrice = 106.30m,
                WeekendPrice = 192.46m,
                CleaningFee = 17.59m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3113),
                User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21925,
                CheckIn = new DateTime(2024, 12, 24),
                CheckOut = new DateTime(2024, 12, 31),
                NumOfGuests = 6,
                WeekdayPrice = 199.68m,
                WeekendPrice = 241.45m,
                CleaningFee = 25.94m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3142),
                User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21925,
                CheckIn = new DateTime(2024, 12, 14),
                CheckOut = new DateTime(2024, 12, 16),
                NumOfGuests = 1,
                WeekdayPrice = 89.88m,
                WeekendPrice = 123.04m,
                CleaningFee = 19.14m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3071),
                User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21926,
                CheckIn = new DateTime(2024, 12, 01),
                CheckOut = new DateTime(2024, 12, 06),
                NumOfGuests = 13,
                WeekdayPrice = 155.03m,
                WeekendPrice = 139.83m,
                CleaningFee = 21.05m,
                DiscountRate = 0.09m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21927,
                CheckIn = new DateTime(2024, 12, 15),
                CheckOut = new DateTime(2024, 12, 24),
                NumOfGuests = 9,
                WeekdayPrice = 223.27m,
                WeekendPrice = 269.55m,
                CleaningFee = 11.35m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3157),
                User = db.Users.FirstOrDefault(u => u.Email == "peterstump@hootmail.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21928,
                CheckIn = new DateTime(2024, 12, 01),
                CheckOut = new DateTime(2024, 12, 04),
                NumOfGuests = 8,
                WeekdayPrice = 83.34m,
                WeekendPrice = 128.05m,
                CleaningFee = 11.29m,
                DiscountRate = 0.21m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                User = db.Users.FirstOrDefault(u => u.Email == "ra@aoo.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21929,
                CheckIn = new DateTime(2024, 12, 01),
                CheckOut = new DateTime(2024, 12, 02),
                NumOfGuests = 13,
                WeekdayPrice = 155.03m,
                WeekendPrice = 139.83m,
                CleaningFee = 21.05m,
                DiscountRate = 0.09m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21929,
                CheckIn = new DateTime(2024, 12, 23),
                CheckOut = new DateTime(2025, 01, 03),
                NumOfGuests = 14,
                WeekdayPrice = 172.83m,
                WeekendPrice = 229.98m,
                CleaningFee = 23.55m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3034),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21929,
                CheckIn = new DateTime(2024, 12, 25),
                CheckOut = new DateTime(2024, 12, 28),
                NumOfGuests = 1,
                WeekdayPrice = 111.73m,
                WeekendPrice = 260.62m,
                CleaningFee = 15.89m,
                DiscountRate = 0.24m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3099),
                User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21930,
                CheckIn = new DateTime(2024, 12, 29),
                CheckOut = new DateTime(2024, 12, 31),
                NumOfGuests = 1,
                WeekdayPrice = 188.53m,
                WeekendPrice = 157.96m,
                CleaningFee = 6.69m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3183),
                User = db.Users.FirstOrDefault(u => u.Email == "tanner@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21931,
                CheckIn = new DateTime(2024, 11, 29),
                CheckOut = new DateTime(2024, 12, 02),
                NumOfGuests = 12,
                WeekdayPrice = 224.98m,
                WeekendPrice = 180.86m,
                CleaningFee = 11.91m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3127),
                User = db.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21932,
                CheckIn = new DateTime(2024, 12, 14),
                CheckOut = new DateTime(2024, 12, 26),
                NumOfGuests = 4,
                WeekdayPrice = 70.24m,
                WeekendPrice = 126.45m,
                CleaningFee = 18.69m,
                DiscountRate = 0.08m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3027),
                User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21932,
                CheckIn = new DateTime(2024, 12, 15),
                CheckOut = new DateTime(2024, 12, 31),
                NumOfGuests = 1,
                WeekdayPrice = 189.98m,
                WeekendPrice = 119.06m,
                CleaningFee = 25.11m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3122),
                User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21932,
                CheckIn = new DateTime(2024, 12, 02),
                CheckOut = new DateTime(2024, 12, 06),
                NumOfGuests = 8,
                WeekdayPrice = 83.34m,
                WeekendPrice = 128.05m,
                CleaningFee = 11.29m,
                DiscountRate = 0.21m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21933,
                CheckIn = new DateTime(2024, 12, 05),
                CheckOut = new DateTime(2024, 12, 10),
                NumOfGuests = 13,
                WeekdayPrice = 155.03m,
                WeekendPrice = 139.83m,
                CleaningFee = 21.05m,
                DiscountRate = 0.09m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                User = db.Users.FirstOrDefault(u => u.Email == "ra@aoo.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21934,
                CheckIn = new DateTime(2024, 12, 26),
                CheckOut = new DateTime(2025, 01, 05),
                NumOfGuests = 1,
                WeekdayPrice = 212.86m,
                WeekendPrice = 212.70m,
                CleaningFee = 6.82m,
                DiscountRate = 0.00m,
                ReservationStatus = ReservationStatus.Valid,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3105),
                User = db.Users.FirstOrDefault(u => u.Email == "louielouie@puppy.com")
            });

            AllReservations.Add(new Reservation
            {
                ConfirmationNumber = 21935,
                CheckIn = new DateTime(2024, 11, 25),
                CheckOut = new DateTime(2024, 11, 27),
                NumOfGuests = 6,
                WeekdayPrice = 106.87m,
                WeekendPrice = 121.74m,
                CleaningFee = 5.62m,
                DiscountRate = 0.06m,
                ReservationStatus = ReservationStatus.Cancelled,
                Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3053),
                User = db.Users.FirstOrDefault(u => u.Email == "rwood@voyager.net")
            });

            // Debugging variables
            int intReservationID = 0;

            try
            {
                foreach (Reservation seedReservation in AllReservations)
                {
                    // Update debugging variables
                    intReservationID = seedReservation.ConfirmationNumber;

                    // Check if reservation exists
                    Reservation dbReservation = db.Reservations
                        .FirstOrDefault(r => r.ConfirmationNumber == seedReservation.ConfirmationNumber);

                    if (dbReservation == null) // Add if not in the database
                    {
                        db.Reservations.Add(seedReservation);
                        db.SaveChanges();
                    }
                    else // Update if it exists
                    {
                        dbReservation.CheckIn = seedReservation.CheckIn;
                        dbReservation.CheckOut = seedReservation.CheckOut;
                        dbReservation.NumOfGuests = seedReservation.NumOfGuests;
                        dbReservation.WeekdayPrice = seedReservation.WeekdayPrice;
                        dbReservation.WeekendPrice = seedReservation.WeekendPrice;
                        dbReservation.CleaningFee = seedReservation.CleaningFee;
                        dbReservation.DiscountRate = seedReservation.DiscountRate;
                        dbReservation.ReservationStatus = seedReservation.ReservationStatus;
                        dbReservation.Property = seedReservation.Property;
                        dbReservation.User = seedReservation.User;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error with detailed message
                StringBuilder msg = new StringBuilder();
                msg.Append("Error adding or updating reservation: ");
                msg.Append(intReservationID);
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}

