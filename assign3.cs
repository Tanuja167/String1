using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class assign3
    {
          /*3.	Write a C# program to count occurrences of a character in given string.*/
            static void Main(string[] args)
            {

                string str = "Good Morning";

                Console.WriteLine(str.IndexOf('o') + "=1st Occurance of o");

                char[] ch = str.ToCharArray();
                int cnt = 0;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (ch[i] == 'o')
                    {
                        cnt++;
                    }
                }
                Console.WriteLine($"Occurance of o={cnt}");
            }
        }
    }


