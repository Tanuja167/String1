using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.String1
{
    internal class separatecharfromstring
    {
        static void Main(string[] args)
        {
            /*string str = "Tanuja";
            int l = 0;

            while(l < str.Length)
            {
                Console.WriteLine(str[l]);
                l++;
            }*/

            //string in reverse

            /*string str = "Tanuja";
            int l = str.Length-1;

            while (l >= 0)
            {
                Console.WriteLine(str[l]);
                l--;
            }*/

            string str = "hello all good morning: ";
            int l = 0;
            int wrd = 0;    
            while(l < str.Length)
            {
                if (str[l]==' ')
                {
                    wrd++;
                }
                l++;
            }
            Console.WriteLine(wrd);
        }
    }
}
