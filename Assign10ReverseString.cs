using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    /*10.	Write a C# program to find reverse of a string.*/
    internal class Assign10ReverseString
    {
        static void Main(string[] args)
        {
            string str1 = "Hello world Good Morning";
            char[] ch = str1.ToCharArray();
            for(int i=ch.Length-1; i>=0; i--)
            {
                Console.Write(ch[i]);
            }

            /*for(int i=str1.Length-1;i>=0;i--)
            {
                Console.Write(str1[i]);
            }*/
        }
    }
}
