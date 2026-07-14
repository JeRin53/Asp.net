using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class A
    {
        public virtual void display()
        {
            Console.WriteLine("Base class ");
        }
    }
    class Program:A
    {
        public override
            void display()
        {
            Console.WriteLine("Derived class ");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.display();
            Console.ReadKey();
        }
    }
}
