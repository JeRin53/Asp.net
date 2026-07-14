
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate int dell(int x, int y);
    class Program
    {
        public int sum(int s, int d)
        {
            return (s + d);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            dell d = new dell(p.sum);
            int s = d(20, 30);
            Console.WriteLine("Sum is {0}", s);
            Console.ReadKey();
        }
    }
}
