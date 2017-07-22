using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Codejam
{
    class InverseFactoring
    {
        public int GetTheNumber(int[] factors)
        {
            int Minimum = Min(ref factors);
            int Maximum = Max(ref factors);
            return (Minimum * Maximum);
        }

        private int Max(ref int[] factors)
        {
            int Index, Max = int.MinValue ;
            for(Index=0;Index<factors.Length;Index++)
            {
                if (factors[Index] > Max)
                    Max = factors[Index];
            }
            return Max;
        }

        private int Min(ref int[] factors)
        {
            int Index, Min = int.MaxValue;
            for (Index = 0; Index < factors.Length; Index++)
            {
                if (factors[Index]!=1&&factors[Index] < Min)
                    Min = factors[Index];
            }
            return Min;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            InverseFactoring inverseFactoring = new InverseFactoring();
            do
            {
                Thread th = new Thread(() =>
                {
                    try
                    {

                        string[] values = input.Split(',');
                        int[] factors = Array.ConvertAll<string, int>(values, delegate (string s) { return Int32.Parse(s); });
                        int validationOp = inverseFactoring.GetTheNumber(factors);
                        Console.WriteLine(validationOp);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception Occured" + ex.ToString());
                    }
                });
                th.Start();
                if (th.Join(1000) == false)
                {
                    Console.WriteLine("Timeout occured");
                    th.Abort();
                    return;
                }
                input = Console.ReadLine();

            } while (input != "-1");
        }

        #endregion
    }
}