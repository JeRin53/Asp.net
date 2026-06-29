using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullname
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("Enter the String S1:");
            s1 = Console.ReadLine();
            Console.WriteLine($"The first name is :{s1}");
            Console.WriteLine("Enter the String S2:");
            s2 = Console.ReadLine();
            Console.WriteLine($"The second name is :{s2}");
            Console.WriteLine($"The full name is :{s1} {s2}");
            Console.ReadKey();
        }
    }
}
