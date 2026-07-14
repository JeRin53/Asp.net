using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_class
{
    sealed class A
    {
        public void display()
        {
            Console.WriteLine("How are u?");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.display();
            Console.ReadKey();
        }
    }
}
