using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace EvenOrOdd
{
    public class Program
    {
        //Assignment Q3: Write a program to check whether input number is even or odd.

        static InputFromConsole reader = new InputFromConsole();
        public static void Main(string[] args)
        {
            long inputNumber=reader.ReadInt("Enter a number");
            Console.WriteLine("Entered number is " + CheckForEvenOrOdd(inputNumber));   //Output
            Console.ReadKey();
        }

        private static string CheckForEvenOrOdd(long inputNumber)
        {
            return inputNumber % 2 == 0 ? "even" : "odd";
        }
    }
}
