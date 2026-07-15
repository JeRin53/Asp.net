
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Jerin");
            ar.Add("hello");
            ar.Add("sugale");
            for (int i = 0; i < ar.Count; i++)
            {
                Console.WriteLine(ar[i]);
            }
            Console.WriteLine("Remove {0}:",ar[1]);
            ar.Remove(ar[1]);
            for (int i = 0; i < ar.Count; i++)
            {
                Console.WriteLine(ar[i]);
            }
            ar.RemoveAt(0);
            for (int i = 0; i < ar.Count; i++)
            {
                Console.WriteLine(ar[i]);
            }

            Console.ReadKey();
        }
    }
}
