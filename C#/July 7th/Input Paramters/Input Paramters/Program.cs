using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Paramters
{
    class Program
    {
        public void check(int x)
        {
            x+=2;
            Console.WriteLine("value:{0}", x);

        }
        static void Main(string[] args)
        {
            int x = 10,a;
            Program pg = new Program();
            pg.check(x);
            Console.WriteLine($"value of main:{x}");
            Console.ReadKey();
        }
    }
}
