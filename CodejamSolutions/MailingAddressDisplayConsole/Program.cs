using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace MailingAddressDisplayConsole
{
    class Program
    {
        /*Assignment Q1: Write a program to display user’s complete mailing address. 
         Accept user’s name, city, street, pin and house no. and store it in a variable and display it.*/

        //This program validates all input provided

        static void Main(string[] args)
        {
            User newUser = new User();
            InputFromConsole newScanner = new InputFromConsole();          //Custom console object
            ValidateCredentials newValidator = new ValidateCredentials();  //Custom validation object
            bool brk = true;
            string firstName="",lastName="",street="",pinCode="",city="";
            int pnCode=0;
            while (brk)                        //Get first name from console until gets a valid input
            {
                firstName = newScanner.Read("Enter your first name");
                brk=!newValidator.IsValidStringName(firstName);
                if (brk)
                    Console.WriteLine("Invalid");
            }
            newUser.FirstName = firstName;
            brk = true;
            while (brk)                         //Get last name from console until gets a valid input
            {
                lastName = newScanner.Read("Enter your last name");
                brk = !newValidator.IsValidStringName(lastName);
                if (brk)
                    Console.WriteLine("Invalid");
            }
            newUser.LastName = lastName;
            brk = true;
            newUser.mailingAddress.SetHouseNo(newScanner.Read("Enter your house number"));   //Get House no
            while(brk)                                   //Get street from console until gets a valid input
            {
                street = newScanner.Read("Enter street");
                brk = !newValidator.IsValidStringName(street);
                if (brk)
                    Console.WriteLine("Invalid");
            }
            newUser.mailingAddress.SetStreet(street);
            brk = true;
            while (brk)                                   //Get city from console until gets a valid input
            {
                city = newScanner.Read("Enter City");
                brk = !newValidator.IsValidStringName(city);
                if (brk)
                    Console.WriteLine("Invalid");
            }
            newUser.mailingAddress.SetCity(city);
            brk = true;
            while (brk)                                  //Get pincode from console until gets a valid input
            {
                pinCode = newScanner.Read("Enter Pincode");
                brk = !newValidator.TryParsePinCode(pinCode,out pnCode);
                if (brk)
                    Console.WriteLine("Invalid");
            }
            newUser.mailingAddress.SetPinCode(pnCode);
            Console.WriteLine("\nUser's Address\n--------------\n"+newUser.mailingAddress);
            Console.ReadKey();
        }
    }
}
