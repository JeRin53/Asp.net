using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_and_string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "Good morning";
            String b = "Hello Friend";
            String c = a.Clone().ToString();
            Console.WriteLine(c);

            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(a.CompareTo(a));
            Console.WriteLine(a.Equals(a));
            Console.WriteLine(a.Equals(b));

            Console.WriteLine(a.StartsWith("g"));
            Console.WriteLine(b.EndsWith("d"));

            Console.WriteLine(a.Contains('M'));
            Console.WriteLine(a.GetType());

            Console.WriteLine(a.IndexOf("o"));
            Console.WriteLine(b.LastIndexOf("o"));


            Console.ReadKey();
        }
    }
}
