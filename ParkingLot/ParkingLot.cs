using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class ParkingLot
    {
        Admin admin;
        RateCard rateCard;
        public List<Spot> spotsList;

        public ParkingLot(List<Spot> spotList)
        {
            this.spotsList = spotList;

        }

        public Ticket Entry(string _registrationNumber, SpotType _vehicleType)
        {
            Car car = new Car
            {
                RegistrationNumber = _registrationNumber,
                vehicleType = _vehicleType,
            };

            Spot _spot = findSpotForVehicleType(_vehicleType);
            Ticket ticket = null;
            if (_spot != null)
            {

                _spot.arrivalTime = DateTime.Now;
                _spot.vehicle = car;
                car.spot = _spot;

                ticket = new Ticket
                {
                    spot = _spot,
                    rateCard = this.rateCard
                };
            } else
            {
                Console.WriteLine("Hey! Looks like there is no parking for your vehicle, would " +
                    "you want to try for upgraded parking at a higher rate. Yes/No");
                string selection = Console.ReadLine();
                if(selection.Equals("Yes"))
                {
                    Spot spotForVehicle = findSpot();
                    if (spotForVehicle == null) return null;

                    spotForVehicle.arrivalTime = DateTime.Now;
                    spotForVehicle.vehicle = car;
                    car.spot = _spot;

                    ticket = new Ticket
                    {
                        spot = spotForVehicle,
                        rateCard = this.rateCard
                    };

                }
                else
                {
                    return null;
                }

            }

            return ticket;
        }


        public bool exit (Ticket ticket, string registrationNumber)
        {
            float paymentAmount;
            if (ticket == null)
            {
                paymentAmount = getAmountForExit(registrationNumber);
            }
            else
            {

                paymentAmount = getAmountForExit(ticket);
            }

            bool status =  admin.verifyPayment(paymentAmount);
            if(status == true)
            {
                ticket.spot.arrivalTime = DateTime.MinValue;
                ticket.spot.vehicle = null;
            }
            return status;

        }


        float getAmountForExit(Ticket ticket)
        {
            DateTime duration =  getDuration(DateTime.Now, ticket.spot.arrivalTime);
            // do your calculation logic

            return 10;
        }

        float getAmountForExit(String registrationNumber)
        {
            Spot getspot = null;
            foreach(Spot spot in spotsList)
            {
                if(spot.vehicle.RegistrationNumber.Equals(registrationNumber))
                {
                    getspot = spot;
                    break;
                }
            }
            DateTime duration = getDuration(DateTime.Now, getspot.arrivalTime);
            // do your calculation logic

            return 10;
        }

        private Spot findSpotForVehicleType(SpotType vehicleType) {

            // You may want to set priority on floor number
            // many consideratin can be done
            // algo for selection
            
           
            return null;

        }

        private Spot findSpot()
        {

            // You may want to set priority on floor number
            // many consideratin can be done
            // algo for selection


            return null;

        }

        DateTime getDuration(DateTime d1, DateTime d2)
        {
            //calculate the diff
            return DateTime.Now;
        }

    }
}
