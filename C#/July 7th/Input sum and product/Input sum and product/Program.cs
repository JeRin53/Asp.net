using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_sum_and_product
{
    class Program
    {
        public void sum(int x,int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum is:{0}",sum);
        }
        public int product(int x,int y)
        {
            int product = x * y;
            Console.WriteLine("Product is :{0}",product);
            return product;
        }
        static void Main(string[] args)
        {
            int d = 10, f = 30;
            Program pg = new Program();
            pg.sum(d, f);
            pg.product(d, f);
            //or
            //int p=pg.product(d, f);
            //Console.WriteLine("Product is:{0}",p);
            Console.ReadKey();

        }
    }
}
