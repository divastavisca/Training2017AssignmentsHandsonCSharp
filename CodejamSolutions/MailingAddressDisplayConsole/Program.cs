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

        //This program validates all inputs provided

        public static void Main(string[] args)
        {
            InputValidator validInput = new InputValidator();
            User newUser = validInput.GetValidInput();
            Console.WriteLine("\nUser's Address\n--------------\n"+newUser.MailingAddress);
            Console.ReadKey();
        }
    }
}
