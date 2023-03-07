using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingService
{
    public class ParkingLot
    {
        public string BranchID { get; private set; }
        public string BranchName { get; private set; }
        public string Location { get; set; }
        public int MaxCapacity { get; private set; }
        public decimal RatePerHour { get; set; }
        private List<ParkingSpace> Spaces;

        public ParkingLot(string branchid, string branchname, string location, int maxcap, decimal rph) 
        {
            this.BranchID = branchid;
            this.BranchName = branchname;
            this.Location = location;
            this.MaxCapacity = maxcap;
            this.RatePerHour = rph;
            this.Spaces = new List<ParkingSpace>(maxcap);
        }
        public ParkingLot(string branchid, string branchname, string location, decimal rph, List<ParkingSpace> sp)
        {
            this.BranchID = branchid;
            this.BranchName = branchname;
            this.Location = location;
            this.MaxCapacity = sp.Count;
            this.RatePerHour = rph;
            this.Spaces = sp;
        }
        public int GetTotalParkingSpaces()
        {
            return this.Spaces.Count;
        }

        public void SetMaxCapacity(int newCapacity)
        {
            this.MaxCapacity = newCapacity;
        }
    }
}
