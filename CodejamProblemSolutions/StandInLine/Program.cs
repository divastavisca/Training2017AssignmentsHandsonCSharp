using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class StandInLine
    {
        int[] Reconstruct(int[] left)
        {
            int[] final = new int[left.Length];
            int i = 1,j,k;
            while(i<=left.Length)
            {
                j = left[i - 1];
                k = 0;
                if (j > 0)
                {
                    while (j > 0)
                    {
                        if(final[k]==0)
                            j--;
                        k++;
                        
                    }
                }
                while (final[k] != 0)
                    k++;
                final[k] = i;
                i++;
            }
            return final;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            StandInLine standInLine = new StandInLine();
            do
            {
                int[] left = Array.ConvertAll<string, int>(input.Split(','), delegate (string s) { return Int32.Parse(s); });
                Console.WriteLine(string.Join(",", Array.ConvertAll<int, string>(standInLine.Reconstruct(left), delegate (int s) { return s.ToString(); })));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
