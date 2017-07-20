using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    //Assignment Q11: Write a program to copy one array’s elements to another array without using array function

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intSource = { 1, 2, 3, 4, 5, 6 }, intTarget=new int[6];
            long[] longSource = { 1234124, 1234656, 45647476, 2423424, 25336346, 21342342 }, longTarget = new long[6];
            char[] charSource = { 'a', 'b', 'c', 'd', 'e', 'f' }, charTarget = new char[6];
            string[] stringSource = { "first", "second", "third", "fourth", "fifth", "last" },stringTarget=new string[6];
            Console.WriteLine("Demo to copy array from source to target  using a custom function\n");
            Console.WriteLine("Integer");
            CopyArray<int>(intSource, intTarget);
            Console.WriteLine("Source Array");
            DisplayArray<int>(intSource);
            Console.WriteLine("Target Array");
            DisplayArray<int>(intTarget);
            Console.WriteLine("Long Integer");
            CopyArray<long>(longSource, longTarget);
            Console.WriteLine("Source Array");
            DisplayArray<long>(longSource);
            Console.WriteLine("Target Array");
            DisplayArray<long>(longTarget);
            Console.WriteLine("Char");
            CopyArray<char>(charSource, charTarget);
            Console.WriteLine("Source Array");
            DisplayArray<char>(charSource);
            Console.WriteLine("Target Array");
            DisplayArray<char>(charTarget);
            Console.WriteLine("Integer");
            CopyArray<string>(stringSource, stringTarget);
            Console.WriteLine("Source Array");
            DisplayArray<string>(stringSource);
            Console.WriteLine("Target Array");
            DisplayArray<string>(stringTarget);
            Console.ReadKey();
        }

        /// <summary>
        /// General function to copy source to target
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="target"></param>
        public static void CopyArray<T>(T[] source,T[] target)
        {
            int i = 0;
            foreach(T element in source)
                target[i++] = element;
        }

        /// <summary>
        /// Function to display general type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        public static void DisplayArray<T>(T[] collection)
        {
            foreach (T element in collection)
                Console.Write(element + " ");
            Console.WriteLine("\n");
        }
    }
}
