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
        /*long SmallestNonPrime(int n)
        {
            long[] primeArray=new long[n+1];
            long temp;
            primeArray[0] = 2;
            int iCounter=1,jCounter;
            temp = 3;
            while (iCounter <= n)
            {
                jCounter = 0;
                while (jCounter < iCounter && primeArray[jCounter]<(int)Math.Sqrt(temp) && temp % primeArray[jCounter] != 0)
                    jCounter++;
                if (jCounter == iCounter||primeArray[jCounter]>=(int)Math.Sqrt(temp))
                {
                    primeArray[iCounter] = temp;
                    iCounter++;
                }
                temp += 2;
            } 
          
            return primeArray[n]* primeArray[n];
        }*/

        long SmallestNonPrime(int n)
        {
            long temp = 2,toBechecked=3,ans=3;
            int counter;
            for(counter=0;counter<=n;)
            {
                temp = 2;
                while(temp<Math.Sqrt(toBechecked))
                {
                    if (toBechecked % temp == 0)
                    {
                        temp++;
                        continue;
                    }
                    else break;
                }
                if (temp >= Math.Sqrt(toBechecked))
                {
                    counter++;
                    ans = toBechecked;
                }
                toBechecked++;
            }
            return (ans-1 )* (ans-1);
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