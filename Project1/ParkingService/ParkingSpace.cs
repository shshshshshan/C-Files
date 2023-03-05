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
        public double Area { get; private set; }
        public Accesibility Accessibility { get; private set; }
        public ParkingLot Lot;

        public ParkingSpace(string spaceid, bool availability, decimal pph, ParkingLot lot)
        {
            this.SpaceID = spaceid;
            this.Availability = availability;
            this.PricePerHour = pph;
            this.Lot = lot;
            this.Area = 0.0;
            this.Accessibility = Accesibility.None;
        }
        public ParkingSpace(string spaceid, bool availability, decimal pph, ParkingLot lot, double a)
        {
            this.SpaceID = spaceid;
            this.Availability = availability;
            this.PricePerHour = pph;
            this.Lot = lot;
            this.Area = a;
            this.Accessibility = Accesibility.None;
        }
        public ParkingSpace(string spaceid, bool availability, decimal pph, ParkingLot lot, double a, Accesibility accessibility)
        {
            this.SpaceID = spaceid;
            this.Availability = availability;
            this.PricePerHour = pph;
            this.Lot = lot;
            this.Area = a;
            this.Accessibility = accessibility;
        }

        public bool IsOccupied()
        {
            // If this.Availablitiy -> not occupied since available
            // Else -> occupied since not available

            return !this.Availability;
        }
    }
}
