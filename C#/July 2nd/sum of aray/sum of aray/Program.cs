using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_aray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.WriteLine("Enter the limit: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the array: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + a[i];
            }
            Console.WriteLine("The array are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of this array is : {0}", sum);
            Console.ReadKey();
        }
    }
}
