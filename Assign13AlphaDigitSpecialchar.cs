using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class Assign13AlphaDigitSpecialchar
    {
        /*13.	Write a C# program to find total number of alphabets, digits or special character in a string.*/
        static void Main(string[] args)
        {
            string str = "Hello @All 001";
            int cnt1 = 0, cnt2 = 0, cnt3 = 0;
            char[] chars = str.ToCharArray();


            for (int i = 0; i < chars.Length; i++)
            {
                if ((chars[i] >= 'A' && chars[i] <= 'Z') || chars[i] >= 'a' && chars[i] <= 'z')
                {
                    cnt1++;
                }


                else if (chars[i] >= '0' && chars[i] <= '9')
                {
                    cnt2++;

                }
                else
                {
                    cnt3++;
                }
            }
            Console.WriteLine("alphabets: " + cnt1);
            Console.WriteLine("Special character: " + cnt2);
            Console.WriteLine("Digits: "+cnt3);
        

            
        }
    }
}
