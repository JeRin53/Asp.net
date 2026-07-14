using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4__Ascii_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 65;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)a + " ");
                    a = a + 1;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
