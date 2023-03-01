using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingService
{
    public class PlateNumberRegex
    {
        public static string UnitedStates = @"^[A-Z]{1,2}\d{1,7}$",
                            Canada = @"^[A-Z]{3}\d{3}$",
                            Mexico = @"^[A-Z]{3}-\d{2}-\d{2}$",
                            UnitedKingdom = @"^[A-Z]{2}\d{2}\s?[A-Z]{3}$",
                            Germany = @"^[A-Z]{1,3}-[A-Z]{1,2}-\d{1,4}$",
                            France = @"^[A-Z]{2}-\d{3}-[A-Z]{2}$",
                            Italy = @"^[A-Z]{2}\s?\d{3}\s?[A-Z]{2}$",
                            Spain = @"^[A-Z]{4}\s?\d{3}[A-Z]{0,2}$",
                            Portugal = @"^\d{2}-[A-Z]{2}-\d{2}$",
                            Netherlands = @"^[A-Z]{2}-\d{2}-[A-Z]{1,3}$",
                            Belgium = @"^\d{3}-[A-Z]{3}$",
                            Switzerland = @"^[A-Z]{2}\s?\d{3}\s?[A-Z]{2}$",
                            Austria = @"^[A-Z]{2}\s?\d{3}\s?[A-Z]{0,2}$",
                            Sweden = @"^[A-Z]{3}\d{2}$",
                            Norway = @"^[A-Z]{2}\d{5}$",
                            Denmark = @"^[A-Z]{2}\d{5}$",
                            Finland = @"^[A-Z]{3}-\d{3}$",
                            Poland = @"^[A-Z]{3}\s?\d{4,5}$",
                            Russia = @"^[A-Z]{3}\d{3}\d{2,3}$",
                            Ukraine = @"^[A-Z]{2}\d{4}\s?[A-Z]{2}$",
                            Turkey = @"^[A-Z]{2}\d{2}\s?[A-Z]{2,3}$",
                            India = @"^[A-Z]{2}\s?\d{2}\s?[A-Z]{0,2}\s?\d{4}$",
                            Japan = @"^\d{2}-[A-Z]{2}-\d{1,4}$",
                            SouthKorea = @"^[A-Z]{2}\d{2}-[A-Z]{1,2}\d{3}$",
                            China = @"^[A-Z]{1}\d{4}[A-Z]{1,2}$",
                            HongKong = @"^[A-Z]{2}\d{4}$",
                            Singapore = @"^[A-Z]{2}\d{3}[A-Z]{1}$",
                            Australia = @"^[A-Z]{3}-\d{3}$",
                            NewZealand = @"^[A-Z]{1,3}\d{1,4}$",
                            SouthAfrica = @"^[A-Z]{2,3}\s?\d{3,6}$",
                            Philippines = @"^[A-Za-z]{3}\s\d{3,4}$";

    }
}
