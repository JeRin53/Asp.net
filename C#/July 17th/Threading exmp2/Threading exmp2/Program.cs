using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_exmp2
{
    class Program
    {
        public static void run1()
        {
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Thread is {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void run2()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine("Thread is {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread ob = new Thread(run1);
            Thread ob2 = new Thread(run2);
            ob.Start();
            ob2.Start();
            Console.ReadKey();
        }
    }
}
