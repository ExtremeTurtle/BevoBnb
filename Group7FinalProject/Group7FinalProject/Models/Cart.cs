namespace Group7FinalProject.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public AppUser User { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Cart()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }

        }
    }
}
