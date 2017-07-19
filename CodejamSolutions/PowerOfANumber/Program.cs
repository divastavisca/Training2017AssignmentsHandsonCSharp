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
            InputFromConsole Reader = new InputFromConsole();
            string number = Reader.Read("Enter the number"),power;
            long inputNumber,inputPower,finalResult=1;
            bool brk = true;
            while (brk)
            {
                if (Int64.TryParse(number, out inputNumber))
                {
                    brk = false;
                }
                else Console.WriteLine("Invalid Input");
            }
            brk = true;
            power = Reader.Read("Enter the power");
            while (brk)
            {
                if (Int64.TryParse(power, out inputPower))
                {
                    brk = false;
                }
                else Console.WriteLine("Invalid Input");
            }
            if (inputPower <= 0)
                Console.WriteLine("Power of ({0},{1}) is {2}", inputNumber, inputPower, Power<double>(inputNumber, inputPower));
            else Console.WriteLine("Power of ({0},{1}) is {2}", inputNumber, inputPower, Power<int>(inputNumber, inputPower));
            Console.WriteLine();
        }

        private T Power<T>(long inputNumber,long inputPower) 
        {
            var ansDouble=1;
            var ansInt=1;
            if(inputPower<=0)
            {
                while(inputPower<0)
                {
                    ansDouble /= inputNumber;
                    inputPower++;
                }
                return ansDouble;
            }
            else
            {
                while(inputPower>0)
                {
                    ansInt *= inputNumber;
                    inputPower--;
                }
                return ansInt;
            }
        }
    }
}
