using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace Codejam
{
    class CreatePairs
    {
        int MaximalSum(int[] data)
        {
            int sum = 0,iCounter,jCounter;
            Array.Sort(data);
            if(data.Length==1)
            {
                return data[0];
            }

            for (iCounter = data.Length - 1; iCounter >= 0 && data[iCounter] > 0; iCounter -= 2)
            {
                if (iCounter - 1>=0&&data[iCounter - 1] > 1)
                    sum += data[iCounter] * data[iCounter - 1];
                else if (iCounter - 1 >= 0 && data[iCounter - 1] == 1)
                    sum += data[iCounter] + data[iCounter - 1];
                else sum += data[iCounter];
            }

            iCounter = 0;
            
                for(iCounter=0;iCounter<data.Length&&data[iCounter]<=0;iCounter+=2)
                {
                    if(iCounter+1<data.Length&&data[iCounter+1]<0)
                    {
                        sum += data[iCounter] * data[iCounter + 1];
                    }
                    else if(data[iCounter]==0||(iCounter+1<data.Length&&data[iCounter+1]==0))
                    {
                        
                    }
                    else if(iCounter + 1 < data.Length && data[iCounter+1]>0)
                    {
                        sum += data[iCounter];
                    }
                    else if(iCounter==data.Length-1)
                    sum += data[iCounter];
            }
          
            return sum;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            CreatePairs createPairs = new CreatePairs();
            do
            {
                int[] data = Array.ConvertAll<string, int>(input.Split(','), delegate (string s) { return Int32.Parse(s); });
                Console.WriteLine(createPairs.MaximalSum(data));
                input = Console.ReadLine();
            } while (input != "*");
        }
        #endregion
    }
}
