using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingAssignment
{
    public class Logger
    {
        public static void AddLog(string log)
        {
            if (!File.Exists("D:/StudentInfoConsole/log.txt"))
            {
                using (File.Create("D:/StudentInfoConsole/log.txt"))
                {

                }
            }
            File.AppendAllText("D:/StudentInfoConsole/log.txt", "\n"+DateTime.UtcNow.AddHours(5.5).ToString() + " " + log);
        }
    }
}
