using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            var square = numbers.Select(x => x * 3);
            Console.WriteLine("The list is:");
            foreach(var i in square)
            {
                Console.WriteLine(i);
            }
            var div3 = numbers.FindAll(x => x % 3 == 0);
            Console.WriteLine("The list is:");
            foreach (var i in div3)
            {
                Console.Write(i);
            }
            Console.ReadKey();

        }
    }
}
