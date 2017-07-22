using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace SwapWithoutUsingThirdVariable
{
    // Assignment Q13: Swap two numbers without using extra temp variable

    public class Program
    {
        static InputFromConsole read = new InputFromConsole();     //Custom input object
        public static void Main(string[] args)
        {
            int firstNumber=0, secondNumber=0;
            bool brk=true;
            while (brk)
            {
                firstNumber = read.ReadInt("Enter first number");    
                secondNumber = read.ReadInt("Enter second number");
                if (firstNumber == secondNumber)
                {
                    Console.WriteLine("Enter different numbers");
                }
                else brk = false;
            }
            firstNumber += secondNumber;
            secondNumber =firstNumber-secondNumber;
            firstNumber -= secondNumber;
            Console.WriteLine("Numbers swapped {0}, {1}", firstNumber, secondNumber);
            Console.ReadKey();
        }
    }
}
