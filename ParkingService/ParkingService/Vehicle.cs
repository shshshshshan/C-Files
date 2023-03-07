using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingService
{
    public class Vehicle
    {
        public string PlateID { get; private set; }
        public User Owner{ get; private set; }
        public double Area { get; private set; }

        public Vehicle(string plateID, User u)
        {
            this.PlateID = plateID;
            this.Owner = u;
            this.Area = 0.0;
        }

        public Vehicle(string plateID, User u, double a)
        {
            this.PlateID = plateID;
            this.Owner = u;
            this.Area = a;
        }

        public static bool checkPlateID(string plateID, string country)
        {
            if(String.IsNullOrEmpty(plateID)) return false;

            return Regex.IsMatch(plateID, country);
        }
    }
}
