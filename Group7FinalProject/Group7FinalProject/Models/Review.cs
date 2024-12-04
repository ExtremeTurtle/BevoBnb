using System.ComponentModel.DataAnnotations;
namespace Group7FinalProject.Models
{
    public enum DisputeStatus { InvalidDispute, ValidDispute, NoDispute, Disputed }

    public class Review
    {
        public Int32 ReviewID { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Rating")]
        public Int32 Rating { get; set; }

        [StringLength(280, ErrorMessage = "Maximum length is 280 characters.")]
        [Display(Name = "Review Text")]
        public String ReviewText { get; set; }

        [Display(Name = "Host Comments")]
        public String? HostComments { get; set; }

        [Display(Name = "Dispute Status")]
        //Stores enum for Status of Dispute
        public DisputeStatus DisputeStatus { get; set; }


        public Property? Property { get; set; }
        public AppUser? User { get; set; }


    }
}
