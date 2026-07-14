using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class gen<X, Y>
    {
        public X a;
        public Y b;
        public gen(X i, Y j)
        {
            a = i;
            b = j;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            gen<int, int> ob = new gen<int, int>(10, 20);
            Console.WriteLine("Sum:{0}", ob.a + ob.b);

            gen<string, string> ob2 = new gen<string, string>("Jerin", "Joejoe");
            Console.WriteLine("SUm:{0}", ob2.a + ob2.b);

            Console.ReadKey();
        }
    }
}
