using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CoreAPI1.Models
{
    public class Parking
    {
        public string CarNumber { get; set; }
        public string CarName { get; set; }
        public char ParkingLot { get; set; }
        public int Hours { get; set; }

    }
}

