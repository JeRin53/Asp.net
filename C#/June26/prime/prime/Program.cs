using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, f = 0;
            Console.WriteLine("Enter the no.:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Not defined");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        f = f + 1;
                    }
                }
                if (f == 2)
                {
                    Console.WriteLine("it is prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
            Console.ReadKey();
        }
    }
}
