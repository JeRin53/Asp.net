using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_for_and_foreach
{
    class Program
    {
        public static void Array(params int[] a)
        {
            Console.WriteLine("The array elements using for loop is:");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine("The array elements using foreach loop is:");
            foreach(int i in a)
            {
                Console.Write(i);
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 1, 6, 5, 3 };
            Array(a);
            Console.ReadKey();
        }
    }
}
