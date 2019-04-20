using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int StudentDegree { get; set; }

        public void DisplayStudent()
        {
            Console.WriteLine($"Student Name {Name} and His Degree {StudentDegree}");
        }
    }
}
