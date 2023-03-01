using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingService
{
    public class ParkingSpace
    {
        public string SpaceID { get; private set; }
        public bool Availability { get; private set; }
        public decimal PricePerHour { get; private set; }
        public ParkingLot Lot;

        public ParkingSpace(string spaceid, bool availability, decimal pph, ParkingLot lot)
        {
            this.SpaceID = spaceid;
            this.Availability = availability;
            this.PricePerHour = pph;
            this.Lot = lot;
        }
    }
}
