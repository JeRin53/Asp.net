using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_class
{
    partial class A
    {
        public String name
        {
            set;
            get;
        }
        public int age { set; get; }
    }
    partial class A
    {
        public String address { set; get; }
        public int salary { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A ob = new A();
            ob.name = "Jerin";
            ob.age = 12;
            ob.address = "Koratty";
            ob.salary = 35000;

            Console.WriteLine($"Name : {ob.name}, Age : {ob.age} , Address: {ob.address} , Salary:{ob.salary} ");
            Console.ReadKey();
        }
    }
}
