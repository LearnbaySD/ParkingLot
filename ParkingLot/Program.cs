using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Spot> spots = new List<Spot>();

            spots.Add(new Spot
            {
                isActive = false,
                vehicle = null,
                spotLocation = new SpotLocation
                {
                    spotId = "F1-H-123",
                    friendlyDirection = "right Corner, 2nd Row",
                    floorNumber = 1
                },
                spotType = SpotType.SMALL
            });

            // keep adding slots
            ParkingLot parkingLot = new ParkingLot(spots);

            //while entry
            Ticket ticket = parkingLot.Entry("KA-01-0977", SpotType.MEDIUM);

            //while exiting
            parkingLot.exit(ticket, null);
            parkingLot.exit(null, "Ka-01-0977");

        }
    }
}
