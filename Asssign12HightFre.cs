using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class Asssign12HightFre
    {
        /*12.	Write a C# program to find highest frequency character in a string.*/

        static void Main(string[] args)
        {

            string str = "Good Morning";
            string[] str1 = str.Split();
            string str2 = " ";
            int maxlen = 0;

            for (int i=0;i<str1.Length; i++)
            {
                int a = str1[i].Length;
               
                if (a > maxlen)
                {
                    maxlen = a;
                    str2 = str1[i];
                }
                Console.WriteLine();

            }
            Console.WriteLine(str2);

            /* char c = 'o';
            int cnt = 0;
             for (int i=0; i<str.Length; i++)
             {
                 if (str[i] == c)
                 {
                     cnt++;   
                 }
             }
             Console.WriteLine("Hight frquency: "+cnt);*/

        }
    }
}
