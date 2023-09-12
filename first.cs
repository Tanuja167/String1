using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OopsPrograms.String1
{
    internal class first
    {
        static void Main(string[] args)
        {
            // string st = new string("hello");
            string st1 = "Hello";
            string st2 = "hello all good morning";
            Console.WriteLine(st1);
            char[] c = st1.ToCharArray();                   //string to char array

            string h = new string(c);                       //string from char array

            Console.WriteLine("compare to: "+st1.CompareTo(st2));

            string[] a = st2.Split();

            
             
            Console.WriteLine("Convert in Character array: ");
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }

            Console.WriteLine("Specific ele: ");
            Console.WriteLine(st1[2]);

            Console.WriteLine("check equality: "+Equals(st1, st2));

            for(int j=0; j<a.Length;j++)
            {
                Console.WriteLine(a[j]);
            }

            string g = new string('f', 20);                // f - 20 times

            Console.WriteLine(g);

            Console.WriteLine("Contains g: "+st1.Contains('g'));



        }
    }
}
