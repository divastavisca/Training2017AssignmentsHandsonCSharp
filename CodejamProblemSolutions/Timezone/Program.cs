using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Codejam
{
    class TimeZone
    {
        public string GetTime(string time)
        {
            string hours = time.Substring(0, 2);
            string minutes = time.Substring(3, 2);
            string gmtOffset = time.Substring(8, 2);
            if (gmtOffset == "??")
                return ("00:00");
            else
            {
                if (hours.Contains("??") && minutes.Contains("??"))
                    return ("00:00");
                else if(hours.Contains("??")&&!minutes.Contains("??"))
                {
                    if(minutes.Contains("?"))
                    {

                    }
                    else
                    {

                    }
                }
                else if(!hours.Contains("??")&&minutes.Contains("??"))
                {
                    if(hours.Contains("?"))
                    {

                    }
                    else
                    {

                    }
                }
                else if(!hours.Contains())
                return time;
            }
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TimeZone timeZone = new TimeZone();
            do
            {
                string validationOp = timeZone.GetTime(input);
                Console.WriteLine(validationOp);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}