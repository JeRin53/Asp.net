using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Hastable :");
            ht.Add(3,"Jerin");
            ht.Add(2,"hello");
            ht.Add(5,"sugale");
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine(ht[4]);

            SortedList sl = new SortedList();
            Console.WriteLine("SortedList : ");
            sl.Add(3, "Jerin");
            sl.Add(2, "hello");
            sl.Add(5, "sugale");
            foreach (DictionaryEntry i in sl)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }

            Console.ReadKey();
        }
    }
}
