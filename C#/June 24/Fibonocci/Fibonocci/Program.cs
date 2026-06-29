using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonocci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a=0,b=1,c,i=2;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("0 1");
            while(i<=n)
            {
                c = a + b;
                a = b;
                b = c;
                i++;
                Console.Write(c);
            }
            Console.ReadKey();
        }
    }
}
