using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject
{
    public class TFQuestion : Question
    {
        public TFQuestion()
        {

        }
        

        public TFQuestion(int id, int degree, string title) : base(id, degree)
        {
            QTitle = title;
        }

        public override string Result()
        {
            return Qbody[this.ResultIndex];
        }


        public override bool IsTrue(int indx)
        {
            if (indx == ResultIndex)
                return true;
            else return false;
        }
    }
}
