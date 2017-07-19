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

        public User GetValidInput()
        {
            User newUser = new User();
            bool brk = true;
            string pinCode = "";
            int pnCode = 0;
            newUser.FirstName = GetInputString("Enter your first name");  //set firstname
            newUser.LastName = GetInputString("Enter your last name");    //set lastname
            brk = true;
            newUser.mailingAddress.SetHouseNo(newScanner.Read("Enter your house number"));   //Get House no
            newUser.mailingAddress.SetStreet(GetInputString("Enter street"));   //set street
            newUser.mailingAddress.SetCity(GetInputString("Enter City"));     //set city
            brk = true;
            while (brk)                                  //Get pincode from console until gets a valid input
            {
                pinCode = newScanner.Read("Enter Pincode");
                brk = !newValidator.TryParsePinCode(pinCode, out pnCode);
                if (brk)
                    Console.WriteLine("Invalid");
            }
            newUser.mailingAddress.SetPinCode(pnCode);   //set pincode
            return newUser;
        }

        public string GetInputString(string query)
        {
            bool brk = true;
            string InputString = "";
            while (brk)                        //Get first name from console until gets a valid input
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
