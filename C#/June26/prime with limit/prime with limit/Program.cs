using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_with_limit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, f = 0;
            Console.WriteLine("Enter the limit.:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                
                if (i == 1)
                {
                    Console.WriteLine("the no. 1 is Not defined");
                }
                else
                {
                    for ( int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            f = f + 1;
                        }
                    }
                    if (f == 2)
                    {
                        Console.WriteLine($"the no.{i}  is prime");
                    }
                    else
                    {
                        Console.WriteLine($"the no. {i} is Not prime");
                    }
                    f = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
