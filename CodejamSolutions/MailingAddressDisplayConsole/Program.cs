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

        static void Main(string[] args)
        {
            User newUser = new User();
            InputFromConsole newScanner = new InputFromConsole();          //Custom console object
            ValidateCredentials newValidator = new ValidateCredentials();  //Custom validation object
            bool brk = true;
            while (brk)
            {
                string firstName = newScanner.Read("Enter your first name");
                if (newValidator.IsValidStringName(firstName))
                {

                }
            }
        }
    }
}
