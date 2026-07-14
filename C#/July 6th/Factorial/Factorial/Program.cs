using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public int fact()
        {
            int n = 5,f=1;
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
           
            return f;
        }

        static void Main(String[] args)
        {
            
            Program ob = new Program();
            int f=ob.fact();
            Console.WriteLine($"Factorial of the no. is {f}");
            Console.ReadKey();
        }
    }
}
