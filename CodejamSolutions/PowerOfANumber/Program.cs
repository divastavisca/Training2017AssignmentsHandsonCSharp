using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace PowerOfANumber
{
    //Assignment Q4: Write a program to calculate power of given number by user

    public class Program
    {
        public static void Main(string[] args)
        {
            InputFromConsole Reader = new InputFromConsole();   //Custom console object
            string number, power;
            long inputNumber=0,inputPower=0;
            bool brk = true;
            while (brk)            //Gets a valid input number
            {
                number = Reader.Read("Enter the number");
                if (Int64.TryParse(number, out inputNumber)&&inputNumber!=0)
                {
                    brk = false;
                }
                else Console.WriteLine("Invalid Input");
            }
            brk = true;
            while (brk)            //Gets a valid power
            {
                power = Reader.Read("Enter the power");
                if (Int64.TryParse(power, out inputPower))
                {
                    brk = false;
                }
                else Console.WriteLine("Invalid Input");
            }
            if (inputPower <= 0)
                Console.WriteLine("Power of ({0},{1}) is {2}", inputNumber, inputPower, Power<double>(inputNumber, inputPower)); //if the power is negative, the output is defined by this
            else Console.WriteLine("Power of ({0},{1}) is {2}", inputNumber, inputPower, Power<int>(inputNumber, inputPower));  //if the power is positive, the output is defined by this
            Console.ReadKey();
        }

        /// <summary>
        /// Returns the power of the inputNumber to the power inputPower
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputNumber"></param>
        /// <param name="inputPower"></param>
        /// <returns></returns>
        private static T Power<T>(long inputNumber,long inputPower)     //Returns the value of the inputNumber to the power inputPower
        {
            double ansDouble=1;
            long ansInt=1;
            if(inputPower<=0)    //if input power is negative
            {
                while(inputPower<0)
                {
                    ansDouble /= inputNumber;
                    inputPower++;
                }
                return (T)Convert.ChangeType(ansDouble,typeof(T));
            } 
            else                 //if input power is positive
            {
                while(inputPower>0)
                {
                    ansInt *= inputNumber;
                    inputPower--;
                }
                return (T)Convert.ChangeType(ansInt,typeof(T));
            }
        }
    }
}
