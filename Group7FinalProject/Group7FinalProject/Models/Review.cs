using System.ComponentModel.DataAnnotations;
namespace Group7FinalProject.Models
{
    public enum DisputeStatus { InProgress, Completed, Resolved }

    public class Review
    {
        [Display(Name = "Review ID")]
        public Int32 ReviewID { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Rating")]
        public Int32 Rating { get; set; }

        [StringLength(280, ErrorMessage = "Maximum length is 280 characters.")]
        [Display(Name = "Review Text")]
        public String ReviewText { get; set; }

        [Display(Name = "Host Comments")]
        public String HostComments { get; set; }

        public Property Property { get; set; }
        public AppUser User { get; set; }


    }
}
