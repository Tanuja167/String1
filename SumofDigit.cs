using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class SumofDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            int sum = 0;
            for(int i=0;i<ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'Z' || ch[i] >= 'a' && ch[i] <='z')
                {
                    continue;
                }
                else
                {
                    int x = (int)char.GetNumericValue(ch[i]);
                    sum = sum + x;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
