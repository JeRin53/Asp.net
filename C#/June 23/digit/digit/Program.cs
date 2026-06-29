using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a no.");
            n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n<10)
            {
                Console.WriteLine($"the no. {n} is one digit");
            }
            else if (n >=10 && n<100)
            {
                Console.WriteLine($"the no. {n} is two digit");
            }
            else if (n >= 100 && n < 1000)
            {
                Console.WriteLine($"the no. {n} is  three digit");
            }
            else
            {
                Console.WriteLine($"the no. {n} is greater than three digits");
            }
            Console.ReadKey();
        }
    }
}
