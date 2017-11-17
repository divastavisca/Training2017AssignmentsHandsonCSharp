using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace StringReversal
{
    public class Program
    {
        //Assignment Q12: Reverse a string using an array

       /// <summary>
       /// Custom input console
       /// </summary>
        static InputFromConsole reader = new InputFromConsole(); //Custom Console


        /// <summary>
        /// Main thread
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string original = reader.Read("Enter a string");
            Console.WriteLine("Reverse string is:\n"+Reverse(original));
            Console.ReadKey();
        }

        /// <summary>
        /// Custom function which reverses a string using an array
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        private static string Reverse(string original)
        {
            char[] auxillary = new char[original.Length]; //Auxillary array
            int counter = original.Length - 1;
            foreach(char c in original)   //Storing each character in original string into array from last
                auxillary[counter--] = c;
            string reverse="";
            foreach (char c in auxillary)
                reverse += c;             //Storing array elements into reverse string
            return reverse;
        }
    }
}
