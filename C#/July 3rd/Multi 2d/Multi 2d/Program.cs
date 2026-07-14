using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_2d
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1, c1, r2, c2;
            Console.WriteLine("Ener the row limit for array 1");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column limit for array 1");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ener the row limit for array 2");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column limit for array 2");
            c2 = Convert.ToInt32(Console.ReadLine());
            int[,] ar1 = new int[r1, c1];
            int[,] ar2 = new int[r2, c2];
            int[,] ar3 = new int[r1, c2];

            if (c1==r2)
            {
                Console.WriteLine("Enter the array elements for array 1");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        ar1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Enter the array elements for array 2");
                for (int i = 0; i < r2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        ar2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("multiplication:");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        for(int k = 0; k < r2; k++)
                        {
                            ar3[i, j] = ar3[i, j] + ar1[i, k] * ar2[k, j];
                            
                        }
                        Console.Write(ar3[i, j] + " ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Output array:");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        Console.Write(ar3[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("invalid entry/operation cannot be performed");
            }
            Console.ReadKey();
        }
    }
}
