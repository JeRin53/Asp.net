using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            Console.WriteLine("The factorial of {0} is {1}", x, factorial(x));
            Console.ReadKey();
        }
        static int factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return (num * factorial(num - 1));
            }
        }
    }
}
