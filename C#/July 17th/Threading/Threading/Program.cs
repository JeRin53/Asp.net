using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        public static void display()
        {
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Thread is {0}", i);
            }
        }
        static void Main(string[] args)
        {
            Thread ob = new Thread(display);
            ob.Start();
            Console.ReadKey();
        }
    }
}
