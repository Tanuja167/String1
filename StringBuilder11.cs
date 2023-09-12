using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class StringBuilder11
    {
        static void Main(string[] args)
        {
            string s1 = "Hello All";
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());

            string s2 = s1 + "Good Morning";
            Console.WriteLine(s2);
            Console.WriteLine(s2.GetHashCode());


            StringBuilder strbuilder = new StringBuilder("Hello to all");
            Console.WriteLine(strbuilder);
            Console.WriteLine(strbuilder.GetHashCode());

            strbuilder.Append("Good Morning");
            Console.WriteLine(strbuilder);
            Console.WriteLine(strbuilder.GetHashCode());



        }
    }
}
