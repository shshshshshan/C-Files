using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingService
{
    public class PhoneNumberRegex
    {
        public static string UnitedStates = @"^(\+1)?\d{10}$",
                            Canada = @"^(\+1)?\d{10}$",
                            Mexico = @"^(\+52)?(\d{10}|\d{2}\s\d{4}\s\d{4})$",
                            UnitedKingdom = @"^(\+44|0)7\d{9}$",
                            Germany = @"^(\+49|0)[1-9]\d{10}$",
                            France = @"^(\+33|0)[67]\d{8}$",
                            Italy = @"^(\+39)?\s?\d{3}\s?\d{7,10}$",
                            Spain = @"^(\+34)?\s?([679]{1})\s?\d{8}$",
                            Portugal = @"^(\+351)?\d{9}$",
                            Netherlands = @"^(\+31|0)6-\d{8}$",
                            Belgium = @"^(\+32|0)4?\d{8}$",
                            Switzerland = @"^(\+41|0)(7[5-9]|[68]\d)\d{7}$",
                            Austria = @"^(\+43|0)6\d{8}$",
                            Sweden = @"^(\+46|0)7\d{8}$",
                            Norway = @"^(\+47)?[49]\d{7}$",
                            Denmark = @"^(\+45)?\s?\d{8}$",
                            Finland = @"^(\+358|0)\s?4?\d{8}$",
                            Poland = @"^(\+48)?\s?\d{9}$",
                            Russia = @"^(\+7|8)?\d{10}$",
                            Ukraine = @"^(\+380|0)9\d{8}$",
                            Turkey = @"^(\+90|0)?5\d{9}$",
                            India = @"^(\+91|0)?[6789]\d{9}$",
                            Japan = @"^(\+81|0)\d{1,4}[\s-]?\d{1,4}[\s-]?\d{4}$",
                            SouthKorea = @"^(\+82|0)\d{1,2}-\d{3,4}-\d{4}$",
                            China = @"^(\+86|0)?1[3456789]\d{9}$",
                            HongKong = @"^(\+852-?)?[569]\d{3}-?\d{4}$",
                            Singapore = @"^(\+65)?[689]\d{7}$",
                            Australia = @"^(\+61|0)4\d{8}$",
                            NewZealand = @"^(\+64|0)2\d{7,9}$",
                            SouthAfrica = @"^(\+27|0)\d{9}$",
                            Algeria = @"^(\+213|0)(5|6|7)\d{8}$",
                            Andorra = @"^(\+376)?\d{6}$",
                            Angola = @"^(\+244)\d{9}$",
                            Philippines = @"^(09|\+639)\d{9}$";
    }
}
