using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class duplicateword
    {
        /*14.	Valid mobile no*/
        static void Main(string[] args)
        {
            string str = "2314585444";
            char[] c= str.ToCharArray();
           
            for(int i=0;i<c.Length; i++)
            {
                if(i<11)
                {
                    if (c[i] >= '0' && c[i] <= '9')
                    {
                        Console.WriteLine(c[i]);
                    }
                }
               
            }
            Console.WriteLine("Valid");



        }
    }
}
