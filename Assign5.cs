using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    /*.5.	Write a C# program to count total number of words in a string.*/

    internal class Assign5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string: ");
            string str = Console.ReadLine();
           // char[] ch = str.ToCharArray();
            string[] str1 = str.Split();
           
            int count = 0;

            for(int i=0; i<str1.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
