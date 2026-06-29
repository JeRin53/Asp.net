using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong_limit
{
    class Program
    {
        static void Main(string[] args)
        {
            int m,n,l,r;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                m = i;
                int s = 0;
                l = i.ToString().Length;
                while (m > 0)
                {
                    r = m % 10;
                    s = s + Convert.ToInt32(Math.Pow(r, l));
                    m = m / 10;
                }
                if (i == s)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();

        }
    }
}
