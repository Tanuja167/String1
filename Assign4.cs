using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    /*4.	Write a C# program to trim leading white space characters in a string.*/
    internal class Assign4
    {
        static void Main(string[] args)
        {
            
            string str = "  Helllo hello  ........"  ;
            Console.WriteLine(str);

            //string str2 = str.Replace(" ","");
            string str2 = (str.TrimStart(' '));
            Console.WriteLine(str2);
        }
    }
}
