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
        public decimal PricePerHour { get; private set; } // In Pesos
        public double Area { get; private set; } // The area in meters 
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

        public decimal TotalCost(DateTime inTime, DateTime outTime)
        {
            // The formula for getting a cost for staying in a certain parking space
            // The formula is subjective:
            // total cost = (out - in) * (area of parking space / 100) + (price per hour * accessibility)
            return ((decimal)(outTime - inTime).TotalMinutes) * (decimal)(this.Area / 100) + (this.PricePerHour * ((int)this.Accessibility));
        }
    }
}
