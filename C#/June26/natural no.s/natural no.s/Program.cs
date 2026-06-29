using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace natural_no.s
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The natural no.s are:");
            for (int i=1;i<=n;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
