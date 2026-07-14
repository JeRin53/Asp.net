using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchial
{
    class A
    {
        public int x, y;
        public void read()
        {
            Console.WriteLine("Enter 2 no.s: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
    class B : A
    {
        public int c;
        public void sum()
        {
            c = x + y;
            Console.WriteLine("Sum of 2 no.s is:{0}", c);
        }
    }

    class D : A
    {
        public int p;
        public void product()
        {
            p = x * y;
            Console.WriteLine("Product of 2 no.s are: {0}", p);
        }
    }


    class C : A
    {

        public void avg()
        {
            Console.WriteLine("Average is : {0}", (x+y) / 2);
        }
        static void Main(string[] args)
        {
            //C obj = new C();
            //D obj1 = new D();
            //Console.WriteLine("Enter two no.s");
            //obj.read();
            //obj.sum();
            //obj1.product();
            //obj.avg();

            B obj1 = new B();
            obj1.read();
            obj1.sum();

            C obj2 = new C();
            obj2.read();
            obj2.avg();

            D obj3 = new D();
            obj3.read();
            obj3.product();
            Console.ReadKey();
        }
    }
}
