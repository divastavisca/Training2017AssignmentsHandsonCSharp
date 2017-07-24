using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    public class RGB
    {
        int GetLeast(string[] picture)
        {
            char positionChar = ' ',toBeCompared;
            int maxStrokesVal = 0,iCounter,jCounter, kCounter, lCounter;
            iCounter = jCounter = kCounter = lCounter = 0;
            while(iCounter < picture.Length)
            {
                positionChar = ' ';
                jCounter = 0;
                while ( jCounter < picture[0].Length)
                {
                    toBeCompared = picture[iCounter][jCounter];
                    if (positionChar != toBeCompared && (toBeCompared == 'R' || toBeCompared == 'G'))
                    {
                        if (positionChar == 'R' || positionChar == 'G')
                        {
                            jCounter++;
                                continue;
                        }
                        maxStrokesVal++;
                    }
                    positionChar = toBeCompared;
                    jCounter++;
                }
                iCounter++;
            }
            kCounter=0;
            while (kCounter < picture[0].Length)
            {
                positionChar = ' ';
                lCounter = 0;
                while ( lCounter < picture.Length)
                {
                    toBeCompared = picture[lCounter][kCounter];
                    if (positionChar != toBeCompared && (toBeCompared == 'B' || toBeCompared == 'G'))
                    {
                        if (positionChar == 'B' || positionChar == 'G')
                        {
                            lCounter++;
                            continue;
                        }
                        maxStrokesVal++;
                    }
                    positionChar = toBeCompared;
                    lCounter++;
                }
                kCounter++;
            }
            return maxStrokesVal;
        }



        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            RGB rgbSolver = new RGB();
            do
            {
                string[] picture = input.Split(',');
                Console.WriteLine(rgbSolver.GetLeast(picture));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}