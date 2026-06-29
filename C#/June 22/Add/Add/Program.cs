using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2,a;
            Console.WriteLine("Enter s1:");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter s2:");
            s2 = Convert.ToInt32(Console.ReadLine());
            a = s1 + s2;
            Console.WriteLine($"The sum is:{a}");
            Console.ReadKey();
        }
    }
}
