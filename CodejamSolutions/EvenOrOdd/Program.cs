using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    public class Program
    {
      //Assignment Q3: Write a program to check whether input number is even or odd.
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            bool brk = true;
            long inputNumber;
            string result="";
            while(brk)
            {
                if(Int64.TryParse(Console.ReadLine(),out inputNumber)&&inputNumber!=0)   //Check for valid input
                {
                    brk = false;
                    result = CheckForEvenOrOdd(inputNumber);   //Final result
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            Console.WriteLine("Entered number is " + result);   //Output
            Console.ReadKey();
        }

        private static string CheckForEvenOrOdd(long inputNumber)
        {
            return inputNumber % 2 == 0 ? "even" : "odd";
        }
    }
}
