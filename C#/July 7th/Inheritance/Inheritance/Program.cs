using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
    {
        public void displayA()
        {
            Console.WriteLine("Base class A");
        }
    }

    class B : A
    {
        public void displayB()

        {
            Console.WriteLine("Base class B");
        }
        public static void Main()
        {
            B obj1 = new B();
            obj1.displayA();
            obj1.displayB();
            Console.ReadKey();
        }
    }
       
 }
