using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] arr = { 2, 3, 4, 5, 1, 2 }; 
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=0;j<arr.Length-1-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
                
            }
            for(int i = 0; i < arr.Length; i++){
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
