using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    class Program
    {
        public static void Main()
        {
            string A = "Jerin";
            Console.WriteLine(A);
            Console.ReadKey();


            int b = 10;
            int d = 20;
            int s = b + d;
            Console.WriteLine("The first number is {0} and the second one is {1} so the sum is {2}", b, d, s);
            Console.WriteLine($"The first number is {b} and the second one is {d} so the sum is {s}");
            Console.ReadKey();
            
        }
    }
}
