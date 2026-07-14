using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class A
    {
        public A()
        {
            Console.WriteLine("Default constructor");
        }
        public A(int a,int b)
        {
            Console.WriteLine("Sum:{0}", a + b);
        }
        static A()
        {
            Console.WriteLine("Static Constructor");
        }
        static void Main()
        {
            A ob = new A();
            ob.A(2,3);
        }
    }
    
    
}
