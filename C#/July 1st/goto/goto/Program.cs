using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter no.");
        check: n=Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                goto check;
            }
            else
            {
                Console.WriteLine($"Number {n} is positive");
            }
            Console.ReadKey();
        }
    }
}
