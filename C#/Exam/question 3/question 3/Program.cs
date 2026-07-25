using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
    abstract class Student
    {
        public abstract  void CalculateGrade();
    }

    class SchoolStudent : Student
    {
        int rollno;
        int marks;
        
        public  SchoolStudent(int a, int b)
        {
            rollno = a;
            marks = b;
        }
        public override void CalculateGrade()
        {
            Console.WriteLine("School Student Roll No: " + rollno);

            if (marks >= 90)
                Console.WriteLine("Grade: A");
            else if (marks >= 75)
                Console.WriteLine("Grade: B");
            else if (marks >= 50)
                Console.WriteLine("Grade: C");
            else
                Console.WriteLine("Grade: Fail");
        }
    }
    class CollegeStudent : Student
    {
        int rollno;
        int marks;

        public  CollegeStudent(int a, int b)
        {
            rollno = a;
            marks = b;
        }

        public override void CalculateGrade()
        {
            Console.WriteLine("College Student Roll No: " + rollno);
            

            if (marks >= 85)
                Console.WriteLine("Grade: Distinction");
            else if (marks >= 60)
                Console.WriteLine("Grade: First class");
            else if (marks >= 50)
                Console.WriteLine("Grade: Second class");
            else
                Console.WriteLine("Fail");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            SchoolStudent obj1 = new SchoolStudent(101, 75);
            obj1.CalculateGrade();
            Console.WriteLine();

            CollegeStudent obj2 = new CollegeStudent(201, 60);
            obj2.CalculateGrade();
            Console.ReadKey();
        }
    }
}
