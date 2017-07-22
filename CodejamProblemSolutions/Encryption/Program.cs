using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Codejam
{
    class Encryption
    {
        public string Encrypt(string test)
        {
            char[] ans = new char[test.Length];
            int i = 96;
            int j = 0;
            while(j<test.Length)
            {
                int k=0;
                while(k<j)
                {
                    if (test[k] == test[j])
                        break;
                    k++;
                }
                if(k>=j)
                {
                    i++;
                    ans[j] = (char)i;
                }
                else
                {
                    ans[j] = ans[k];
                }
                j++;    
            }
            string final = new string(ans);
            return final;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Encryption encryption = new Encryption();
            do
            {
                Thread th = new Thread(() =>
                {
                    try
                    {

                        string validationOp = encryption.Encrypt(input);
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