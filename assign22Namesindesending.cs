using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    /*22.	Create an array of 10 names sort in descending order*/
    internal class assign22Namesindesending
    {
        static void Main(string[] args)
        {
            string[] str = new string[10];

            for(int i=0; i<str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }
            
        }
    }
}
