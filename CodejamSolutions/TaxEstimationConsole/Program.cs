using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace TaxEstimationConsole
{
    //Assignment Q5: Write a program of tax calculation. 
    //Accept money as input from the user and calculate the tax using following pattern
         /*             MONEY PERCENTAGE  TOTAL
                        Less than 10,000	5%	
                        10,000 to 100,000	8%	
                        More than 100,000	8.5%	*/
    public class Program
    {
        public static InputFromConsole reader = new InputFromConsole();   //Custom console object

        static void Main(string[] args)
        {
            int money = reader.ReadInt("Enter your income");       //Get input
            Console.WriteLine("Tax payable "+TaxToBePaid(money));  //Output tax
            Console.ReadKey();
        }

        public static double TaxToBePaid(int salary)               //Returns tax payable on the salary amount
        {
            double tax=0;
            if (salary < 10000)          //if money is less then 10000, tax payable is 5%
                tax = salary * 5;
            else if (salary <= 100000)   //if money is between 10000 and 100000, tax payable is 8%
                tax = salary * 8;
            else tax = salary * 8.5;     //if money is more than 100000, tax payable is 8.5%
            return tax/100;
        }
    }
}
