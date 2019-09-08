using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class ParkingDashboard
    {
        ParkingLot parkingLot;
        public ParkingDashboard(ParkingLot _parkingLot)
        {
            this.parkingLot = _parkingLot;
        }

        public void displayFreeSpotsByType()
        {
            // Count total vehicles parked
            // Free spaces by type
            int count = 0;
            const int types = (int)(SpotType.END);
            int[] countByType = new int[types];
            //instialize array to 0;

            foreach (Spot spot in parkingLot.spotsList)
            {
                if(spot.spotType == SpotType.SMALL)
                {
                    if (spot.vehicle != null) count++;
                    else countByType[(int)SpotType.SMALL]++;
                }
                // do for other types

            }

           //print here;
        }

    }
}