using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(122);
            al.Add(200);
            al.Add(300);
            foreach(int i in al)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
