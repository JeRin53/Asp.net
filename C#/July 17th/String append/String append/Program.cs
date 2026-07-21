using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_append
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "bbb";
            StringBuilder sb = new StringBuilder("Haii");
            sb.Append(" mwone");
            sb.Append(" Enthoke und?");
            sb.AppendLine();
            sb.Append("Welcome !!");
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
