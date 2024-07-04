namespace PracticaAPI.Models
{
    public class Room
    {
        
            public int Id { get; set; }
            public int Number { get; set; }
            public string RoomType { get; set; }
            public string RoomStatus { get; set; }
            public decimal PricePerNight { get; set; }
            public ICollection<Reservation> Reservations { get; set; }
       

    }
}
