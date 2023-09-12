using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class frquenself   //duplicateword
    {
        static void Main(string[] args)
        {
            string str = "Hello All Hello";
            string[] str2 = str.Split();

            

            for(int i=0;i<str2.Length; i++)
            {
                
                int cnt = 1;
                for(int j=i+1;j<str2.Length;j++)
                {
                    if (str2[i] == str2[j])
                    {
                        cnt++;
                        str2[j] = " ";

                        
                    }
                }
                if (str2[i] != " ")
                {
                    Console.WriteLine(str2[i]+ " "+cnt);
                }

                
            }
            

        }
    }
}
