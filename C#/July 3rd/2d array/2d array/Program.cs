using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c;
            Console.WriteLine("Ener the row limit");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column limit");
            c = Convert.ToInt32(Console.ReadLine());
            int[,] ar = new int[r,c];
            Console.WriteLine("Enter the array elements");
            for(int i = 0; i < r ; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    ar[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Output array:");
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Console.Write(ar[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
