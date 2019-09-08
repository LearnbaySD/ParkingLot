using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    abstract class IVehicle
    {
        public string RegistrationNumber { get; set; }
        public Spot spot { get; set; }
        public SpotType vehicleType { get; set; }
    }

    class Car : IVehicle
    {
    }

    class Bike : IVehicle
    {
    }
}
