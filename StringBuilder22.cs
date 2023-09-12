using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class StringBuilder22
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Hello All");
            Console.WriteLine(stringBuilder);

            stringBuilder.Append("Good Morning");
            Console.WriteLine(stringBuilder);

            stringBuilder.Remove(2, 4);
            Console.WriteLine(stringBuilder);

            Console.WriteLine(stringBuilder.Capacity);

            stringBuilder.Clear();
            Console.WriteLine(stringBuilder);
        }
    }
}
