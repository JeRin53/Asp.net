using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface A
    {
        void sum(int x, int y);
    }
    class B
    {
        public int product(int x, int y)
        {
            return (x * y);
        }
    }
    class C:B,A
    {
        public void sum(int x,int y)
        {
            Console.WriteLine("Sum is:{0} ", x + y);
        }
        static void Main(string[] args)
        {
            C obj1 = new C();
            obj1.sum(2, 3);
            int p= obj1.product(3, 2);
            Console.WriteLine("Product is:{0}",p);
            Console.ReadKey();
        }
    }
}
