using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList arr = new ArrayList();
            Console.WriteLine("enter the limit:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("enter the elements:");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                arr.Add(a[i]);
            }
            int even = 0;
            Console.WriteLine("Even:");
            foreach(int i in arr)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    even++;                
                }
            }
            Console.WriteLine("Odd numbers:");
            int odd = 0;
            foreach(int i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    odd++;
                }
            }
            Console.WriteLine("The no. of even elements are:{0}", even);
            Console.WriteLine("The no. of odd elements are:{0}", odd);
            Console.ReadKey();
        }
    }
}
