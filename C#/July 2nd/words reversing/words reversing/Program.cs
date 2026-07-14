using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words_reversing
{
    class Program
    {
        static void Main(string[] args)
        {
            String s,rev=" ";
            Console.WriteLine("Write the String:");
            s=Console.ReadLine();
            String[] ar = s.Split(',');
            int l = ar.Length;
            for(int i = l - 1; i >= 0; i--)
            {
                rev = rev + ar[i]+" ";
            }
            Console.WriteLine("the reverse string is {0}", rev);
            Console.ReadKey();

        }
    }
}
