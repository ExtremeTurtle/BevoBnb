using Group7FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Group7FinalProject.Models
{
    public enum HireStatus { Employed, Fired}
    public class AppUser : IdentityUser
    {
        // Basic Information
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Birthday is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Street Address is required.")]
        [Display(Name = "Street Address")]
        public string Address { get; set; }


        public HireStatus? HireStatus { get; set; }


    

        // Navigation Properties
        public Cart Cart { get; set; }
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

