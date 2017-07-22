using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class Anagrams
    {
        int GetMaximumSubset(string[] words)
        {
            char[][] temp = new char[words.Length][];
            string[] newwords;
            int Icounter, CountAns = 0, Jcounter;
            bool[] SetFound = new bool[words.Length];
            for (int i = 0; i < words.Length; i++)
                SetFound[i] = false;
            for (Icounter = 0; Icounter < words.Length; Icounter++)
            {
                newwords = new string[words.Length];
                temp[Icounter] = words[Icounter].ToCharArray();
                BubbleSort(ref temp[Icounter]);
            }
            for (Icounter = 0; Icounter < words.Length; Icounter++)
            {
                if (!SetFound[Icounter])
                {
                    SetFound[Icounter] = true;
                    CountAns++;
                    for (Jcounter = 0; Jcounter < words.Length; Jcounter++)
                    {
                        if (Icounter != Jcounter && !SetFound[Jcounter] && AreEqual(ref temp[Icounter], ref temp[Jcounter]))
                        {
                            SetFound[Jcounter] = true;
                        }


                    }
                }
            }
            return CountAns;
        }


        private bool AreEqual(ref char[] first, ref char[] second)
        {
            if (first.Length != second.Length)
                return false;
            else
            {
                int i = 0;
                while (i < first.Length)
                {
                    if (first[i] != second[i])
                        break;
                    i++;
                }
                if (i != first.Length)
                    return false;
                else return true;
            }
        }



        private void BubbleSort(ref char[] arr)
        {
            int temp = 0;
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = (char)temp;
                    }
                }
            }
        }
        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Anagrams anagramSolver = new Anagrams();
            do
            {
                string[] words = input.Split(',');
                Console.WriteLine(anagramSolver.GetMaximumSubset(words));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }

}
