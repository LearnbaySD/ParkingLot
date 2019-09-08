using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Spot
    {
        public SpotLocation spotLocation;
        public SpotType spotType;
        public bool isActive;
        public IVehicle vehicle;
        public DateTime arrivalTime;
    }
}
