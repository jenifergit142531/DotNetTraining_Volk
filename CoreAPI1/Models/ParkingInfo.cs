namespace CoreAPI1.Models
{
    public class ParkingInfo : IParking
    {
        public IEnumerable<Parking> GetParkings()
        {
            List<Parking> details = new List<Parking>()
           {
               new Parking
               {
                   CarNumber="ap123c",
                   CarName="vento",
                   ParkingLot='G',
                   Hours=3
               },
               new Parking
               {
                   CarNumber="DL112334",
                   CarName="Octavia",
                   ParkingLot='I',
                   Hours=5
               },
               new Parking
               {
                   CarNumber="TN1234",
                   CarName="Polo",
                   ParkingLot='A',
                   Hours=1
               },
               new Parking
               {
                   CarNumber="KL3456",
                   CarName="BMW",
                   ParkingLot='B',
                   Hours=2
               },
           };
            return details;
        }
    }
}
