using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace OutParametersDemo
{
    //Assignment Q9:  Write a program in which accept four numbers from the user and returns add, 
    //                subtraction and multiplication of the value using out parameter.

    public class Program
    {
        static InputFromConsole reader = new InputFromConsole();  //Custom Console

        /// <summary>
        /// Main Thread
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int first, second, third, fourth,result;                 //Input variables and result variable
            first = reader.ReadInt("Enter 1st number");              //Get first input
            second = reader.ReadInt("Enter 2nd number");             //Get second input
            third = reader.ReadInt("Enter 3rd number");              //Get third input
            fourth = reader.ReadInt("Enter 4th number");             //Get fourth input
            Addition(first, second, third, fourth, out result);      //Use of "out" for calculating addition
            Console.WriteLine("Addition Result: "+result);           //Print addition result
            Subtraction(first, second, third, fourth, out result);   //Use of "out" for calculating subtraction
            Console.WriteLine("Subtraction Result: " + result);      //Print subtraction result
            Multiplication(first, second, third, fourth, out result);//Use of "out" for calculating multiplication
            Console.WriteLine("Multiplication Result: " + result);   //Print multiplication result
            Console.ReadKey();
        }


        /// <summary>
        /// This function returns addition result in the out "result" parameter
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="fourth"></param>
        /// <param name="result"></param>
        public static void Addition(int first,int second,int third , int fourth,out int result)
        {
            result = first + second + third + fourth;
        }


        /// <summary>
        /// This function returns subtraction result in the out "result" parameter
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="fourth"></param>
        /// <param name="result"></param>
        public static void Subtraction(int first, int second, int third, int fourth, out int result)
        {
            result = first - second - third - fourth;
        }


        /// <summary>
        /// This function returns multiplication result in the out "result" parameter
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="fourth"></param>
        /// <param name="result"></param>
        public static void Multiplication(int first, int second, int third, int fourth, out int result)
        {
            result = first * second * third * fourth;
        }
    }
}
