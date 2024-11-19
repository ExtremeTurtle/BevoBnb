using Group7FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Group7FinalProject.Models
{
    public enum HireStatus { Employed, Fired}
    public class AppUser : IdentityUser
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
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string Address { get; set; }

        public HireStatus HireStatus { get; set; }


    

        // Navigation Properties
        public List<Reservation> Reservations { get; set; }  // Customers
        public List<Property> Properties { get; set; }  // Hosts
        public List<Review> Reviews { get; set; }  // Customers
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
        
    }
}

