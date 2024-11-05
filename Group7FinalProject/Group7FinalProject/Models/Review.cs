namespace Group7FinalProject.Models
{
    public enum DisputeStatus { InProgress, Completed, Resolved }

    public class Review
    {

        public Int32 ReviewID { get; set; }

        public Int32 Rating { get; set; }

        public String ReviewText { get; set; }

        public String HostComments { get; set; }

        public Property Property { get; set; }

    }
}
