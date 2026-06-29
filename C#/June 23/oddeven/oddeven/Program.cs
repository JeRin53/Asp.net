using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter a no.");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 2 == 0)
            {
                Console.WriteLine("The given no.{0} is even", n1);
            }
            else
            {
                Console.WriteLine("The given no.{0} is odd", n1);
            }
            Console.ReadKey();
        }
    }
}
