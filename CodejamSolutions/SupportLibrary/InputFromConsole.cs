using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{

    public class InputFromConsole
    {
        /// <summary>
        /// Displays the statement and reads a line from the console
        /// </summary>
        /// <param name="statement"></param>
        /// <returns></returns>
        public string Read(string statement) //Displays the statement and reads a line from the console
        {
            Console.WriteLine(statement);
            return Console.ReadLine();
        }

        public int ReadInt(string statement)
        {
            bool brk=true;
            int number = 0;
            while (brk)   //Gets a valid number
            {
                if (Int32.TryParse(Read(statement), out number))
                {
                    brk = false;
                }
                else Console.WriteLine("Invalid Input");
            }
            return number;
        }
    }
}
