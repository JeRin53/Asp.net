using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    static class Test
    {
        public static int Largest(params int[] ar)
        {
            int lar = ar[0];
            for(int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > lar)
                {
                    lar = ar[i];
                }
            }
            return lar;

        }
        public static void Smallest(params int[] ar)
        {
            int smal = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < smal)
                {
                    smal = ar[i];
                }
            }
            Console.WriteLine("the largest of the array is :{0} ", smal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5 };
            int lar=Test.Largest(ar);
            Console.WriteLine("the largest of the array is :{0} ", lar);
            Test.Smallest(ar);
            Console.ReadKey();
        }
    }
}
