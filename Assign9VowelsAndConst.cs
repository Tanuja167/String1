using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class Assign9VowelsAndConst
    {
        /*9.	Write a C# program to count total number of vowels and consonants in a string.*/
        static void Main(string[] args)
        {
            string str = "Hello All";
            char[] c = str.ToCharArray();
            int cnt1 = 0, cnt2 = 0;

            
                for(int i=0;i<c.Length; i++)
                {
                    if (c[i] == 'a' || c[i] == 'e' || c[i] == 'i' || c[i] == 'o'|| c[i] == 'u' || c[i] == 'A' || c[i] == 'I'
                        || c[i] == 'O' || c[i] == 'U')
                    {
                        cnt1++;
                        
                    }
                    else if (c[i]!= ' ')
                    {
                        cnt2++;
                    }
                }
            
            Console.WriteLine("vowels count: "+cnt1);
            Console.WriteLine("Constants: "+cnt2);



        }
    }
}
