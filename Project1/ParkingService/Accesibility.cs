using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingService
{
    public enum Accesibility
    {
        /// <summary>
        /// The accessibility in which a car can park. Usually described as to if the parking space is closer
        ///     to the entrace or exit of the parking lot or not.
        ///     
        /// None   - Default value for unspecified accessibility.
        ///     
        /// Easy   - Usually a parking space that is close to the entrance or exit of a parking lot meaning
        ///          faster unloading and departure.
        ///         
        /// Medium - Usually a parking space that is in the close middle of the entrance or exit of the parking
        ///          lot.
        ///          
        /// Hard   - Usually a parking space that is in the middle of the entrance or exit of the parking lot.
        /// 
        /// The accessibility of a parking space depends on the structure of the parking lot. For more
        ///     flexibility, the accessibility will be determined by its corresponding parking lot structure.
        /// </summary>
        /// 
        None = 0, Easy = 20, Medium = 10, Hard = 5
    }
}
