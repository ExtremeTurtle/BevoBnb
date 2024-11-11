using Group7FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Group7FinalProject.Models
{
    public class AppUser
    {
        // Basic Information
        [Key]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string Address { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        // Role: Customer, Host, Admin
        [Required]
        [Display(Name = "User Role")]
        public string Role { get; set; }

        // Navigation Properties
        public List<Reservation> Reservations { get; set; } = new List<Reservation>(); // Customers
        public List<Property> Properties { get; set; } = new List<Property>(); // Hosts
        public List<Review> Reviews { get; set; } = new List<Review>(); // Customers
        public AppUser()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }

            if (Properties == null)
            {
                Properties = new List<Property>();
            }

            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }
        }
        // Custom Validation for Age
        public static ValidationResult ValidateAge(DateTime birthday, ValidationContext context)
        {
            var age = DateTime.Now.Year - birthday.Year;

            if (birthday > DateTime.Now.AddYears(-age)) age--;

            return age >= 18 ? ValidationResult.Success : new ValidationResult("User must be at least 18 years old.");
        }
    }
}

