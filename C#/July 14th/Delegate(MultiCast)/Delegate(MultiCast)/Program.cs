using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_MultiCast_
{
    public delegate void dell(int a, int b);
    class Program
    {
        public void sum(int x,int y)
        {
            Console.WriteLine("Sum is:{0}", x + y);
        }
        public void product(int a,int b)
        {
            Console.WriteLine("product of this is : {0}", a * b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            dell d = new dell(p.sum);
            d(10, 20);
            dell q = new dell(p.product);
            q(10, 20); 
            d += new dell(p.product);
            d(1, 2);
            Console.ReadKey();
        }
    }
}
