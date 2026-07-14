using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_and_sum
{
    class A
    {
        public int x, y;
        public void read()
        {
            
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
        }
    class B : A
        {
            public void sum()
            {
                Console.WriteLine("Sum of 2 no.s is:{0}",x+y);
            }
            static void Main(string[] args)
            {
                B obj = new B();
                Console.WriteLine("Enter two no.s");
                obj.read();
                obj.sum();
                Console.ReadKey();
            }
        }

        
    }
}
