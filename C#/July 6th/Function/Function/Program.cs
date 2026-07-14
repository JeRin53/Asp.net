using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        public void display()
        {
            Console.WriteLine("Simple function");
        }

        public static void sfun()
        {
            Console.WriteLine("static function");
        }

        public int sum()
        {
            int x = 10, y = 20;
            int sum = x + y;
            return sum;

        }

        public static void Main()
        {
            Program ob = new Program();
            ob.display();
            sfun();
            int s=ob.sum();
            Console.WriteLine($"the sum is:{s}");
            Console.ReadKey();
        }
    }
}
