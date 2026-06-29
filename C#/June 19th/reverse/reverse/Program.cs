using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n,r=0,rev=0;//123
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The  no. is :{n1}");
            n = n1;
            while (n > 0)
            {
                r = n % 10;//3
                rev = rev*10 +r;
                n = n / 10;//12
            }
            Console.WriteLine($"The reverse no. is :{rev}");
            if (n1 == rev)
            {
                Console.WriteLine("it is pallindrome");
            }
            else
            {
                Console.WriteLine("it is not pallindrome");
            }
            Console.ReadKey();

        }
    }
}
