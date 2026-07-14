using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{

    class Program
    {
        

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Array size:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the array elements:");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to be searched:");
            int s = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= arr.Length; i++)
            {
                if (arr[i] == s)
                {
                    Console.WriteLine("Element found at pos:{0}",i);
                }
            }
            Console.ReadKey();

        }
    }
}
