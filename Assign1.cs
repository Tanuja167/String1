using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class Assign1
    {
    /*1.	WAP to split string into 2 tokens where string is “HELLO$WORLD” */

        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";

            string[] str1 = str.Split('$');
            Console.WriteLine(str1[0]);
            Console.WriteLine(str1[1]);


        }
    }
}
