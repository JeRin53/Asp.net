using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapwithno3rdvar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine()); //10
            b = Convert.ToInt32(Console.ReadLine()); //20
            Console.WriteLine("The  no.s before swapping are: {0} & {1}", a, b);
            a = a + b; //30
            b = a - b; //10
            a = a - b;
            Console.WriteLine("The swaped no.s are: {0} & {1}", a, b);
            Console.ReadKey();
        }
    }
}
