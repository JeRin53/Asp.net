using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_parameters
{
    class Program
    {
        public static int Display(int x,out int y)
        {
            x = x + 20;
            y = x + 10;
            return x;
        }
        static void Main(string[] args)
        {
            int x = 1, y,b;
            
            b=Display(x,out y);
            Console.WriteLine("a:{0} & b:{1}",b, y);
            Console.ReadKey();

        }
    }
}
