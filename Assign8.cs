﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class Assign8
    {
        /*8.	Write a C# program to toggle case of each character of a string.*/
        static void Main(string[] args)
        {
            string str1 = "Good MorNing";
            char[] c = str1.ToCharArray();
            
            for(int i=0;i<c.Length;i++)
            {
                if (c[i] >='A' && c[i] <= 'Z')
                {

                    c[i] = (char)(c[i] + 32);
                    //Console.Write(c[i]);

                }
                else if (c[i] >='a' && c[i] <= 'z')
                {
                    c[i] = (char)(c[i] - 32);
                   // Console.Write(c[i]);
                }
                
            }
            Console.WriteLine(str1);
            Console.WriteLine(c);

        }
    }
    
}
