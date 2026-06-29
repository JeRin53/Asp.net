using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, t;
            Console.WriteLine("Enter n1:");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n2:");
            n2 = Convert.ToInt32(Console.ReadLine());
            t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("n1 is :{0}", n1);
            Console.WriteLine("n2 is :{0}", n2);
            Console.ReadKey(); 
        }
    }
}
