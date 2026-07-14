using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatic
{
    class A
    {
        public int num1 { set;  get; }
        public int num2 { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A ob = new A();
            ob.num1 = 10;
            ob.num2 = 20;
            Console.WriteLine("the two numbers sum is = {0}", ob.num1 + ob.num2);
            Console.ReadKey();
        }
    }
}
