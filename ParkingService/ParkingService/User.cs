using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingService
{
    public class User
    {
        public string Username { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string ContactNumber { get; private set; }
        public string Country { get; private set; }
        private List<Vehicle> vehicles;
        public List<Vehicle> Vehicles
        {
            get 
            {
                return new List<Vehicle>(vehicles);
            }
        }
        private List<ParkingSpace> parkingSpaces;
        public List<ParkingSpace> ParkingSpaces
        {
            get
            {
                return new List<ParkingSpace>(parkingSpaces);
            }
        }


        public User(string username, string fullname, string email, string contactNumber, string country)
        {
            this.Username = username;
            this.FullName = fullname;
            this.Email = email;
            this.ContactNumber = contactNumber;
            this.Country = country;
            this.vehicles = new List<Vehicle>();
            this.parkingSpaces = new List<ParkingSpace>();
        }

        public void AddVehicle(Vehicle vehicle) 
        {
            this.vehicles.Add(vehicle);
        }

        public void AddParkingSpace(ParkingSpace space)
        {
            this.parkingSpaces.Add(space);
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
