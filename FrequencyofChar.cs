using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class FrequencyofChar
    {
        /*12.	Write a C# program to find highest frequency character in a string.*/
        static void Main(string[] args)
        {
            string str = "Hello All";
           

            char[] ch = str.ToCharArray();
            
            for (int i = 0; i < str.Length; i++)
            {
                int cnt = 1;
                for (int j=i+1; j<ch.Length; j++)
                {
                   
                    if (str[i] == ch[i])
                    {
                        cnt++;
                       
                    }
                   
                }
                Console.WriteLine($"{ch[i]} - {cnt}");


            }


        }
    }
}
