using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class RateCard // singleton or static
    {
        Dictionary<SpotType, float> firstHourRateCard;
        Dictionary<SpotType, float> followingHourRateCard;

        RateCard()
        {
            // adding the rates.
        }
        void updateFirstHourMap(SpotType spotType, float val)
        {
            this.firstHourRateCard.Add(spotType, val);
        }
        void updateFollowingHourMap(SpotType spotType, float val)
        {
            this.followingHourRateCard.Add(spotType, val);
        }
    }
}
