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
        }
}
