using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class Dating
    {
        String Dates(String circle, int k)
        {
            string final="";
            bool[] dateFound = new bool[circle.Length];
            int temp,position=-1,min,inner,foundPos=0;
            while (arePairsLeft(ref circle,ref dateFound))
            {
                temp = k;
                while (temp > 0)
                {
                    position = (position + 1) % circle.Length;
                    if (!dateFound[position])
                        temp--;
                }
                min = int.MaxValue;
                inner = (position + 1) % circle.Length;
                if (circle[position]>96)
                {
                    while(inner!=position)
                    {
                        if(circle[inner]<91&&!dateFound[inner]&&circle[inner]<min)
                        {
                            min = circle[inner];
                            foundPos = inner;
                        }
                        inner = (inner + 1) % circle.Length;
                    }
                }
                else
                {
                    while (inner != position)
                    {
                        if (circle[inner] >96 && !dateFound[inner] && circle[inner] < min)
                        {
                            min = circle[inner];
                            foundPos = inner;
                        }
                        inner = (inner + 1) % circle.Length;
                    }
                }
                dateFound[position] = dateFound[foundPos] = true;
                final += circle[position];
                final += circle[foundPos];
                final += ' ';
            }
            final=final.Trim();
            final = final.Trim(',');
            return final;
        }

        private bool arePairsLeft(ref String circle,ref bool[] dateFound)
        {
            int girls = 0, boys = 0, counter = 0 ;
            while((girls<1||boys<1)&&(counter<circle.Length))
            {
                if(!dateFound[counter])
                {
                    if (circle[counter] > 96 && circle[counter] < 123)
                        girls++;
                    else boys++;
                    if (girls >= 1 && boys >= 1)
                        return true;
                }
                counter++;
            }
            if (counter == circle.Length)
                return false;
            return true;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Dating dating = new Dating();

            do
            {
                string[] values = input.Split(',');
                Console.WriteLine(dating.Dates(values[0], Int32.Parse(values[1])));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}