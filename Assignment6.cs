using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    /*6.	Write a C# program to remove all occurrences of a character from string.*/
    internal class Assignment6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string: ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            Console.WriteLine("enter character that we want to remove");
            char c = Convert.ToChar(Console.ReadLine());

            for(int i=0;i<ch.Length; i++)
            {
                if (ch[i]== c)
                {
                    continue;
                }
                else
                {
                    Console.Write(ch[i]);
                }
            }
        }
    }
}
