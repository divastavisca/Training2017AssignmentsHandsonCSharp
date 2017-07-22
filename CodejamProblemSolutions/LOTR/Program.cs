using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    class LOTR
    {
        int GetMinimum(int[] replies)
        {
            int ans = 0, Icounter = 0 ,temp=0,Jcounter=0;
            bool[] Check = new bool[replies.Length];
            while (Icounter < replies.Length)
                Check[Icounter++] = false;
            Icounter = 0;
            while(Icounter<replies.Length)
            {
                
                if (!Check[Icounter])
                {
                    Check[Icounter] = true;
                    temp = replies[Icounter];
                    ans += temp + 1;
                    Jcounter = 0;
                    while (Jcounter < replies.Length &&temp>0)
                    {
                        if (Icounter != Jcounter&&!Check[Jcounter])
                        {
                            if (replies[Icounter] == replies[Jcounter])
                            {
                                temp--;
                                Check[Jcounter] = true;
                            }
                        }
                        Jcounter++;
                    }
                }
                Icounter++;
            }
            
            return ans;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            LOTR lotr = new LOTR();
            String input = Console.ReadLine();
            do
            {
                int[] replies = Array.ConvertAll<string, int>(input.Split(','), delegate (string s) { return Int32.Parse(s); });
                Console.WriteLine(lotr.GetMinimum(replies));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion

    }
}