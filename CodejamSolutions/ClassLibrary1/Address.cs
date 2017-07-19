using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public class Address
    {
        public string HouseNo;
        public string Street { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }

        /// <summary>
        /// Get the complete mailing address
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (this.HouseNo + ", " + this.Street + ", " + this.City + ", " + this.PinCode);
        }
    }
}
