using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _or_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a no.");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine($"the no. {n} is grater than 0");
            }
            else if (n < 0)
            {
                Console.WriteLine($"the no. {n} is less than 0");
            }
            else
            {
                Console.WriteLine($"the no. {n} is  0");
            }
            Console.ReadKey();
        }
    }
}
