using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgsDemo
{
    //Assignment Q10 : Write a C# program to demonstrate command line argument. 
    //                 Accept 2 numbers from the user and calculate area and perimeter of rectangle.

    public class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            double length, breadth;    //Properties of a rectangle
            if(args!=null&&args.Length==2)    //Check for input conditions
            {
                if(IsValid(args,out length,out breadth))        //Check for valid input
                {
                    Console.WriteLine("Perimeter: "+Perimeter(length,breadth));   //Print required perimeter
                    Console.WriteLine("Area: "+Area(length,breadth));             //Print required area
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Invalid Input");
            Console.ReadKey();
        }

        /// <summary>
        /// Get perimeter of a rectangle of length "length" and breadth "breadth"
        /// </summary>
        /// <param name="length"></param>
        /// <param name="breadth"></param>
        /// <returns></returns>
        private static double Perimeter(double length, double breadth)
        {
            return (2 * (length + breadth));
        }

        /// <summary>
        /// Get area of a rectangle of length "length" and breadth "breadth"
        /// </summary>
        /// <param name="length"></param>
        /// <param name="breadth"></param>
        /// <returns></returns>
        private static double Area(double length, double breadth)
        {
            return (length * breadth);
        }

        /// <summary>
        /// Validate command line inputs as a double data type and returns length and breadth as out parameters
        /// </summary>
        /// <param name="args"></param>
        /// <param name="length"></param>
        /// <param name="breadth"></param>
        /// <returns></returns>
        private static bool IsValid(string[] args,out double length,out double breadth)
        {
            length = breadth = 0;
            //Try parsing string inputs to double
            return double.TryParse(args[0], out length) && double.TryParse(args[1], out breadth);   
        }
    }
}
