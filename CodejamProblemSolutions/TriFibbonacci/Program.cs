using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class TriFibonacci
    {
        public int Complete(int[] test)
        {
            int Index,ValueRep=-1,Internal;
            if (test[0] < 0 || test[1] < 0 || test[2] < 0)
            {
                Index = 0;
                while (test[Index] != -1)
                    Index++;
                if(Index+3>=test.Length)
                {
                    if(Index==0)
                    {
                        test[0] = test[3] - test[1] - test[2];
                    }
                    else if(Index==1)
                    {
                        test[1] = test[3] - test[0] - test[2];
                    }
                    else if(Index==2)
                    {
                        test[2] = test[3] - test[1] - test[0];
                    }
                    ValueRep = test[Index];
                    if (ValueRep <= 0)
                        return -1;
                }
                else
                {
                    test[Index] = test[Index + 3] - test[Index + 2] - test[Index + 1];
                    ValueRep = test[Index];
                    if (ValueRep <= 0)
                        return -1;
                }
            }
            else if (!IsValid(ref test))
            {

            }
            else
            {
              for (Index = 3; Index < test.Length; Index++)
              {
                 if (test[Index] == -1)
                 {
                            test[Index] = test[Index - 1] + test[Index - 2] + test[Index - 3];
                            ValueRep = test[Index];
                            if (ValueRep <= 0)
                               return -1;
                    }
              }
                
            }
            if (IsValid(ref test))
                return ValueRep;
            else return -1;

        }

        private bool IsValid(ref int[] test)
        {
            int Index = 3;
            while(Index<test.Length&&test[Index]>0)
            {
                if (test[Index] != test[Index - 1] + test[Index - 2] + test[Index - 3])
                    return false;
                Index++;
            }
            return true;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TriFibonacci triFibonacci = new TriFibonacci();
            do
            {
                string[] values = input.Split(',');
                int[] numbers = Array.ConvertAll<string, int>(values, delegate (string s) { return Int32.Parse(s); });
                int result = triFibonacci.Complete(numbers);
                Console.WriteLine(result);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}