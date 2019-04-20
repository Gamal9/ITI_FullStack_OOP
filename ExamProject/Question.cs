using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject
{
    public class Question
    {
        public Question()
        {

        }
        public Question(int id, int degree)
        {
            QuestionID = id;
            QuestionDegree = degree;
        }

        public string[] Qbody { get; set; }
        public int QuestionID { get; set; }
        public string QTitle { get; set; }
        public int ResultIndex { get; set; }
        public int QuestionDegree { get; set; }

        public virtual string Result()
        {
            return "";
        }

        public virtual bool IsTrue(int indx)
        {
            return false;
        }
    }
}
