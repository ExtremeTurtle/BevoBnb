using System.ComponentModel.DataAnnotations;
namespace Group7FinalProject.Models
{
    public enum DisputeStatus { InProgress, Completed, Resolved }

    public class Review
    {
        [Display(Name = "Review ID")]
        public Int32 ReviewID { get; set; }

        [Display(Name = "Rating")]
        public Int32 Rating { get; set; }

        [Display(Name = "Review Text")]
        public String ReviewText { get; set; }

        [Display(Name = "Host Comments")]
        public String HostComments { get; set; }

        public Property Property { get; set; }
        public AppUser User { get; set; }


    }
}
