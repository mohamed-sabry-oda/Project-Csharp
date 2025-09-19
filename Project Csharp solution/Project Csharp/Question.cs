using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Csharp
{
    internal abstract class Question
    {
        public string Header { get; set; } // is number of question
        public string Body { get; set; } // the body of question
        public int Marks { get; set; } // Mark for question
        public AnswerList Answers { get; set; }

        public Question (string header,string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = new AnswerList ();
        }

        public abstract void Print(); // to show the question whatever TF or MCQ

    }
}
