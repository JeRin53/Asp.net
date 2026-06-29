using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestof2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter a no. :");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another no. :");
            n2 = Convert.ToInt32(Console.ReadLine());
            if(n1>n2)
            {
                Console.WriteLine("No. {0} is greatest", n1);
            }
            else
            {
                Console.WriteLine("No.{0} is greatest", n2);
            }
            Console.ReadKey();

        }
    }
}
