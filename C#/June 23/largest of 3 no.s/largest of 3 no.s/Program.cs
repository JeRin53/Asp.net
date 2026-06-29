using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_of_3_no.s
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;
            Console.WriteLine("Enter a no.");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd no.");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd no.");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1>n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("The no. {0} is greatest",n1);
                }
                else
                {
                    Console.WriteLine("The no. {0} is greatest", n3);
                }
            }
            else if(n2<n3)
            {
                Console.WriteLine("The no. {0} is greatest", n3);
            }
            else
            {
                Console.WriteLine("The no. {0} is greatest", n2);
            }
            Console.ReadKey();
        }
    }
}
