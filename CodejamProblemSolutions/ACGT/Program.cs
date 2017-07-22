using System;

namespace CodeJam
{
    class ACGT
    {
        int MinChanges(int maxPeriod, string[] acgt)
        {
            int minReplacements=0;
            string final = String.Concat(acgt);
            int index, period = maxPeriod, a, c, g, t, currentReplacements, periodValue, mn;
            minReplacements =int.MaxValue;
            while(period>=1) //Check for replacements for each period in the closed interval [1,maxPeriod]
            {
                periodValue = 0;
                currentReplacements = 0;
                while (periodValue<period) //Check for specific period value index for specific period
                {
                    index = 0;
                    a = c = g = t = 0;
                    while (index+periodValue<final.Length)  //Check for particular period value for each possible string for specific period
                    {
                        if (final[index + periodValue] == 'A')
                            a++;
                        else if (final[index + periodValue] == 'C')
                            c++;
                        else if (final[index + periodValue] == 'G')
                            g++;
                        else t++;
                        index += period;
                    }
                    mn = a + c + g + t - max(a, c, g, t);
                    periodValue++;
                    currentReplacements += mn; //Computing total replacements in a particular period
                }
                if (currentReplacements < minReplacements)
                  minReplacements = currentReplacements;
                period--;
            }
            if (minReplacements == int.MaxValue)
                return 0;
            return minReplacements;
        }
        
        private int max(int a,int c,int g,int t)
        {
            if(a>c)
            {
                if(a>g)
                {
                    if (a > t)
                        return a;
                    return t;
                }
                else
                {
                    if (g > t)
                        return g;
                    else return t;
                }
            }
            else
            {
                if(c>g)
                {
                    if (c > t)
                        return c;
                    return t;
                }
                else
                {
                    if (g > t)
                        return g;
                    return t;
                }
            }
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            ACGT aCGT = new ACGT();
            String input = Console.ReadLine();
            do
            {
                var inputParts = input.Split('|');
                int maxPeriod = int.Parse(inputParts[0]);
                string[] acgt = inputParts[1].Split(',');
                Console.WriteLine(aCGT.MinChanges(maxPeriod, acgt));
                input = Console.ReadLine();
                
            } while (input != "-1");
        }
        #endregion
    }
}