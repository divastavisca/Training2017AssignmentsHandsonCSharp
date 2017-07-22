using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace RefrenceTypeAndValueType
{
    //Assignment Q8: Explain difference between value type and reference type by writing a suitable C# example.

    //Demonstrating using Swapping by value and by reference through objects

    public class Program
    {
        static InputFromConsole reader = new InputFromConsole();  //Custom console reader
        public static void Main(string[] args)
        {
            RefernceAndValueTypeExample demo = new RefernceAndValueTypeExample();
            IntExampleClass firstNumber = new IntExampleClass(reader.ReadInt("Enter first number"));   //Gets valid First number
            IntExampleClass secondNumber = new IntExampleClass(reader.ReadInt("Enter second number")); //Gets valid Second number
            Console.WriteLine("Demonstrating Value types by swapping 2 numbers by function, passing their values");
            Console.WriteLine("Before Swapping\nFirst number={0}\nSecond number={1}\n", firstNumber.Number,secondNumber.Number);
            demo.SwapUsingValue(firstNumber.Number, secondNumber.Number);   //Swap using values
            Console.WriteLine("After Swapping\nFirst number={0}\nSecond number={1}\n", firstNumber.Number, secondNumber.Number);
            Console.WriteLine("Now demonstrating reference types by swapping 2 numbers by function, by passing objects");
            Console.WriteLine("Before Swapping\nFirst number={0}\nSecond number={1}\n", firstNumber.Number, secondNumber.Number);
            demo.SwapUsingReference(firstNumber, secondNumber);             //Swap using objects
            Console.WriteLine("After Swapping\nFirst number={0}\nSecond number={1}\n", firstNumber.Number, secondNumber.Number);
            Console.ReadKey();
        }
    }


    public class RefernceAndValueTypeExample
    {
        public void SwapUsingValue(int firstNumber,int secondNumber)   //Function swaps using value
        {
            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber -= secondNumber;
        }

        public void SwapUsingReference(IntExampleClass firstNumber, IntExampleClass secondNumber)  //Function swaps using object reference
        {
            firstNumber.Number += secondNumber.Number;
            secondNumber.Number = firstNumber.Number - secondNumber.Number;
            firstNumber.Number -= secondNumber.Number;
        }
    }

    public class IntExampleClass    //Temporary class for holding values to demonstrate pass by reference and value
    {
        public int Number;
        public IntExampleClass(int number)
        {
            Number = number;
        }
    }
}
