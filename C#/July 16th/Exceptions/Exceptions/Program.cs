using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x, y;
                Console.WriteLine("ENter the numbers :");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}", x / y);
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero error");
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("FInally block");
            }
            Console.ReadKey();
        }
    }
}
