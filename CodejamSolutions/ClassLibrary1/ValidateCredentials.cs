using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    /// <summary>
    /// Provides support for validating different user related information
    /// </summary>
    public class ValidateCredentials
    {
        /// <summary>
        /// Validate whether the provided string is a valid gender name
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public bool IsValidGender(string gender)
        {
            gender = gender.ToLower();
            if (gender.Equals("male") || gender.Equals("female"))   //Check for possible gender
                return true;
            return false;
        }

        /// <summary>
        /// Validate whether the provided string is a valid string with alphanumeric characters
        /// </summary>
        /// <param name="stringName"></param>
        /// <returns></returns>
        public bool IsValidStringName(string stringName)
        {
            int result;
            long longResult;
            double checkForDouble;
            bool check;
            if (Int32.TryParse(stringName, out result))  //test whether string is not integer
                return false;
            else if (bool.TryParse(stringName, out check))   //test whether string is boolean or not
                return false;
            else if (Int64.TryParse(stringName, out longResult))    //test whether string is long int or not
                return false;
            else if (double.TryParse(stringName, out checkForDouble))    //test whether string is double or not
                return false;
            return true;
        }
        
        /// <summary>
        /// Tries parsing the string to a valid Pin code
        /// </summary>
        /// <param name="pinNumber"></param>
        /// <param name="pin"></param>
        /// <returns></returns>
        public bool TryParsePinCode(string pinCode,out int pin)
        {
            if (Int32.TryParse(pinCode, out pin))
            {
                if(pin.ToString().Length==6)
                    return true;
                return false;
            }
            return false;
        }
    }
}
