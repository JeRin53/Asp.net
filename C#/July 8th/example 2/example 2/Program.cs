using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_2
{
    class A
    {
        public int x, y;
        public void read()
        {

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


    class C : B
    {

        public void avg()
        {
            Console.WriteLine("Average is : {0}", c / 2);
        }
        static void Main(string[] args)
        {
            C obj = new C();
            Console.WriteLine("Enter two no.s");
            obj.read();
            obj.sum();
            obj.avg();
            Console.ReadKey();
        }
    }
}

