using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    interface sum1
    {
        void sum();
    }
    interface product1
    {
        void product();
    }

    class operations : sum1, product1
    {
        public int A
        {
            get;
            set;
        }
        public int B
        {
            get;
            set;
        }
        public int C
        {
            get;
            set;
        }

        public operations(int a,int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void sum()
        {
            Console.WriteLine("Sum is :{0}", A+B+C);
        }
        public void product()
        {
            Console.WriteLine("Product is :{0}", A*B*C);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            operations obj = new operations(2, 3, 4);
            obj.sum();
            obj.product();
            Console.ReadKey();

        }
    }
}
