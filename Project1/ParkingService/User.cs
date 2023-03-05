using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingService
{
    public abstract class User
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Country { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public User(string username, string fullname, string email, string contactNumber, string country)
        {
            this.Username = username;
            this.FullName = fullname;
            this.Email = email;
            this.ContactNumber = contactNumber;
            this.Country = country;
            this.Vehicles = new List<Vehicle>();
        }

        public void addVehicle(Vehicle vehicle) 
        {
            this.Vehicles.Add(vehicle);
        }

        public static bool checkUsername(string username) 
        {
            if(String.IsNullOrEmpty(username)) return false;

            return Regex.IsMatch(username, @"^[A-Za-z][A-Za-z0-9_]{5,20}$");
        }

        public static bool checkEmail(string email)
        {
            if (String.IsNullOrEmpty(email)) return false;

            return Regex.IsMatch(email, @"^[\p{L}\p{M}\p{N}._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", RegexOptions.IgnoreCase);
        }

        public static bool checkContactNumber(string contactNumber, string country)
        {
            if(String.IsNullOrEmpty(contactNumber) || String.IsNullOrEmpty(country)) return false;

            return Regex.IsMatch(contactNumber, country);
        }
    }
}
