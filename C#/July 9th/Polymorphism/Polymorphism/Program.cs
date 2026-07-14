using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class A
    {
        public void sum()
        {
            Console.WriteLine("Enter 2 no.s for sum() : ");
            int c = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is :{0}", c + b);
        }
        public void sum(int c,int b)
        {
            Console.WriteLine("The sum is :{0}", c + b);
        }
        public void sum(double c,double b)
        {
            Console.WriteLine("The sum is :{0}", c + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.sum();
            Console.WriteLine("The int :");
            int c = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            obj.sum(c, b);
            Console.WriteLine("The double :");
            double a = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            obj.sum(a, d);
            Console.ReadKey();
        }
    }
}
 