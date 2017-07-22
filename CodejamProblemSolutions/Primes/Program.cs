using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    public class EngineersPrimes
    {
        long SmallestNonPrime(int n)
        {
            long lastPrime = 2,startNumber = 3; ;
            int PrimeCounter = 1;
            n++;
            while (PrimeCounter < n)
            {
                if (PrimeCheck(startNumber))
                {
                    lastPrime = startNumber;
                    PrimeCounter++;
                }
                startNumber += 2;
            }
            return lastPrime * lastPrime;
        }

        public bool PrimeCheck(long startNumber)
        {
            int  iCounter = 2;
            while(iCounter <= Math.Sqrt(startNumber))
            {
                if (startNumber % iCounter == 0)
                {
                    return false;
                }
                iCounter++;
            }
            return true;
        }




        #region Testing code Do not change
        public static void Main(String[] args)
        {
            EngineersPrimes engineersPrimes = new EngineersPrimes();
            String input = Console.ReadLine();
            do
            {
                Console.WriteLine(engineersPrimes.SmallestNonPrime(Int32.Parse(input)));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}