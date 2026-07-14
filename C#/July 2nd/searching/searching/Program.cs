using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searching
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,ser,f=0,pos=0;
            Console.WriteLine("Enter the limit: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the search element: ");
            ser = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the array: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The array are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] == ser)
                {
                    f = f + 1;
                    pos = i;
                }  
            }
            if (f>0)
            {
                
                    Console.WriteLine("Search element {0}  found {1} times and position {2}", ser,f,pos);

            }
            else
            {
                Console.WriteLine("Search element {0} not found", ser);
            }
            Console.ReadKey();
        }
    }
}
