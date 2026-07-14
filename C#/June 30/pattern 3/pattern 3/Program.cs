using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a=2;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j=1;j<=i; j++)
                {
                    Console.Write(a+" ");
                    a=a+2;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
