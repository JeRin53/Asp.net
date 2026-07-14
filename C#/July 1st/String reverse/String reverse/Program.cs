using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            String s;
            Console.WriteLine("Enter a String:");
            s = Console.ReadLine();
            l = s.Length;
            Console.WriteLine();
            for(int i=l-1;i>=0;i--)
            {
                Console.Write(s[i]);
            }
            Console.ReadKey();

        }
    }
}
