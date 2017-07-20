using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public class Address
    {
        private string house_number;
        private string street;
        private string city;
        private int pin_code;

        /// <summary>
        /// Get the complete mailing address
        /// </summary>
        /// <returns></returns>
        ///
        public override string ToString()
        { 
            return (this.house_number + ", " + this.street + ", " + this.city + ", " + this.pin_code);
        }

        /// <summary>
        /// Set House No
        /// </summary>
        /// <param name="hNo"></param>
        public void SetHouseNumber(string hNo)
        {
            house_number = hNo;
        }

        /// <summary>
        /// Set Street
        /// </summary>
        /// <param name="street"></param>
        public void SetStreet(string street)
        {
            this.street = street;
        }

        /// <summary>
        /// Set City
        /// </summary>
        /// <param name="city"></param>
        public void SetCity(string city)
        {
            this.city = city;
        }

        /// <summary>
        /// Set Pincode
        /// </summary>
        /// <param name="pinCode"></param>
        public void SetPinCode(int pinCode)
        {
            pin_code = pinCode;
        }
    }
}
