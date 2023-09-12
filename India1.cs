using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class India1
    {
        static void Main(string[] args)
        {
            string st = "India is the best";

            /*char[] c = st.ToCharArray();

            for(int i=c.Length-1; i>=0; i--)
            {
                Console.WriteLine(c[i]);
            }*/
            /*string s = " ";

            for(int i=st.Length-1;i>=0;i--)
            {
                s = s + st[i];
            }
            Console.WriteLine(s);*/

            string[] str = st.Split(' ');
            string str1 = " ";
            string str2 = str[0];
            string str3 = str[str.Length - 1];

            for(int i=str.Length-2;i>=1;i--)
            {
                char[] ch = str[i].ToCharArray();
                for(int j=ch.Length-1;j>=0;j--)
                {

                    str1 = str1+ ch[j];
                    
                }
            }
            Console.WriteLine(str2 + " "+ str1 + " " + str3);
            //Console.WriteLine(str1);
        }
    }
}
