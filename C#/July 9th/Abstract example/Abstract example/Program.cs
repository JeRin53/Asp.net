using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_example
{
    abstract class A
    {
        public void Display()
        {
            Console.WriteLine("Non abstract method");
        }
        public abstract  void AbsMethod();

    }
    class B:A
    {
        public override void AbsMethod()
        {
            Console.WriteLine("The method is abstract");
        }
        static void Main(string[] args)
        {
            B ob = new B();
            ob.AbsMethod();
            Console.ReadKey();
        }
    }
}
