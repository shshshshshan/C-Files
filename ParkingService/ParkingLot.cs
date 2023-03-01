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
        public List<ParkingSpace> Spaces;

        public ParkingLot(string branchid, string branchname, string location, int maxcap, decimal rph) 
        {
            this.BranchID = branchid;
            this.BranchName = branchname;
            this.Location = location;
            this.MaxCapacity = maxcap;
            this.RatePerHour = rph;
            this.Spaces = new List<ParkingSpace>(maxcap);
        }
    }
}
