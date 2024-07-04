namespace PracticaAPI.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ReservationStatus { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
