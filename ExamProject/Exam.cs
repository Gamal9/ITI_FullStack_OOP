using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject
{
    public class Exam
    {
        public int ExamID { get; set; }
        public string ExamName { get; set; }
        public bool ExamType { get; set; }
        public Question[] Questions { get; set; }
        public Student[] Students { get; set; }
    }
}
