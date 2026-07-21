using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x;
                Console.WriteLine("Enter age:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x <= 0)
                {
                    throw new Exception("Age cannot be zero or less than zeroo");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
