using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_reference
{
    class Program
    {
        public void check(ref int x)
        {
            x += 2;
            Console.WriteLine("value:{0}", x);

        }
        static void Main(string[] args)
        {
            int x = 10, a;
            Program pg = new Program();
            pg.check(ref x);
            Console.WriteLine($"value of main:{x}");
            Console.ReadKey();
        }
    }
}
