using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingService
{
    public abstract class Vehicle
    {
        public string plateID { get; private set; }
        public User user { get; private set; }

        public Vehicle(string plateID, User u)
        {
            this.plateID = plateID;
            this.user = u;
        }

        public static bool checkPlateID(string plateID, string country)
        {
            if(String.IsNullOrEmpty(plateID)) return false;

            return Regex.IsMatch(plateID, country);
        }
    }
}
