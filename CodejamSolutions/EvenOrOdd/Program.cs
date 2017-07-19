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
                    result = inputNumber % 2 == 0 ? "Entered number is even" : "Entered number is odd";   //Final result
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            Console.WriteLine(result);   //Output
            Console.ReadKey();
        }
    }
}
