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
            string output;
            if (IsEven(reader.ReadInt("Enter a number")))
            {
                output = "Even";
            }
            else output = "Odd";
            Console.WriteLine("Entered number is " + output );   //Output
            Console.ReadKey();
        }

        private static bool IsEven(long inputNumber)
        {
            return inputNumber % 2 == 0 ? true : false;
        }
    }
}
