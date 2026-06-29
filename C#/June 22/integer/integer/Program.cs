using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a no.");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The no. is:{n}");
            Console.ReadKey();
        }
    }
}
