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
            List<int> item = new List<int>();
            List<int> pos = new List<int>();
            for(int i = 0; i < n; i++)
            {
                if (arr[i] == s)
                {
                    item.Add(arr[i]);
                    pos.Add(i);
                }
            }
            Console.WriteLine("the items are:");
            for(int d = 0; d < item.Count; d++)
            {
                Console.WriteLine(item[d] +","+ pos[d]);
            }
            Console.ReadKey();

        }
    }
}
