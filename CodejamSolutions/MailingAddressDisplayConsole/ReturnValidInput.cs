using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace MailingAddressDisplayConsole
{
    public class ReturnValidInput
    {
        InputFromConsole newScanner = new InputFromConsole();          //Custom console object
        ValidateCredentials newValidator = new ValidateCredentials();  //Custom validation object
        /// <summary>
        /// Gets valid input input and returns a User object
        /// </summary>
        /// <returns></returns>
        public User GetValidInput()
        {
            User newUser = new User();
            bool brk = true;
            string pinCode = "";
            int pnCode = 0;
            newUser.FirstName = GetInputString("Enter your first name");  //set firstname
            newUser.LastName = GetInputString("Enter your last name");    //set lastname
            newUser.mailingAddress.SetHouseNo(newScanner.Read("Enter your house number"));   //Get House no
            newUser.mailingAddress.SetStreet(GetInputString("Enter street"));   //set street
            newUser.mailingAddress.SetCity(GetInputString("Enter City"));     //set city
            brk = true;
            while (brk)  //Get pincode from console until gets a valid input
            {
                pinCode = newScanner.Read("Enter Pincode");
                brk = !newValidator.TryParseNumber(pinCode,6,out pnCode);
                if (brk)
                    Console.WriteLine("Invalid");
            }
            newUser.mailingAddress.SetPinCode(pnCode);   //set pincode
            return newUser;
        }

        /// <summary>
        /// Gets valid string
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public string GetInputString(string query)
        {
            bool brk = true;
            string InputString = "";
            while (brk)                        //Gets required input from console until it is not valid
            {
                InputString = newScanner.Read(query);
                brk = !newValidator.IsValidStringName(InputString);
                if (brk)
                    Console.WriteLine("Invalid");
            }
            return InputString;
        }
    }
}
