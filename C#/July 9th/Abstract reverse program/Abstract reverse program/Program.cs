using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_reverse_program
{
    abstract class A
    {
        public void Display()
        {
            Console.WriteLine("Non abstract method");
        }
        public abstract  void AbsMethod(int n);

    }
    class B:A
    {
        public override void AbsMethod(int n)
        {
            int rev = 0;
            int m = n;
            while (n > 0)
            {
                int r = n % 10;
                rev = (rev * 10) + r;
                n = n / 10;
            }
            
            Console.WriteLine("The reverse of a number {0} is : {1}", m,rev);
        }
        static void Main(string[] args)
        {
            B ob = new B();
            Console.WriteLine("Enter the no. to be reversed");
            int n=Convert.ToInt32(Console.ReadLine());
            ob.AbsMethod(n);
            Console.ReadKey();
        }
    }
}
