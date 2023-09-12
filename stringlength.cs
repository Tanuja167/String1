using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class stringlength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string: ");
            string str = Console.ReadLine();
            int cnt = 0;
            for(int i=0;i<str.Length;i++)
            {
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
