using System.ComponentModel.DataAnnotations;

namespace BookShowApp.Models
{
    public class Booking
    {
        [Key]
        public Guid BookingId { get; set; }
        public string MovieName { get; set; }
        public int Price { get; set; }
        public int Seats { get; set; }

    }
}
