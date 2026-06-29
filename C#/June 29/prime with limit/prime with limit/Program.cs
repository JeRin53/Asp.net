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
            int n, f;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime no.s are :");
            for(int i = 1; i <= n; i++)
            {
                f = 0;
                for(int j=1;j<=i;j++)
                {
                    if (i % j == 0)
                    {
                        f = f + 1;
                    }
                }
                if (f == 2)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
