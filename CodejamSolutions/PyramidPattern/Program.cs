using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace PyramidPattern
{
    //Assignment Q7:Using for loop print the following output on console.

    /*     1
          121
         12321
        1234321
       123454321      */

    public class Program
    {
        static InputFromConsole reader = new InputFromConsole();    //custom console object

        public static void Main(string[] args)
        {
            int patternLength = reader.ReadInt("Enter the pattern length");
            PrintPattern(patternLength);    //final output pattern
        }

        private static void PrintPattern(int patternLength)   //function to print pyramid pattern of specific length
        {
            int rowCount = 1,temp;
            while(rowCount<=patternLength)
            {
                temp = 1;
                while (temp <= patternLength - rowCount)
                {
                    Console.Write(" ");
                    temp++;
                }
                temp = 1;
                while (temp < rowCount)
                    Console.Write(temp++);
                while (temp > 0)
                    Console.Write(temp--);
                Console.WriteLine();
                rowCount++;
            }
            Console.ReadKey();
        }
    }
}
