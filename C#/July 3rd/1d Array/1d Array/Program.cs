using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1d_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 8, 3, 6, 83, 45, 65, 22, 1 };
            int n = arr.Length, i, j;
            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Numbers after sorting");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.ReadKey();

        }
    }
}