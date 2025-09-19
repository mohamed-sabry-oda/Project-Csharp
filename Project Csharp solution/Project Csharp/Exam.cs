using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Csharp
{
    public enum ExamMode
    {
        Starting,
        Queued,
        Finished
    }
    internal abstract class Exam
    {
        public int Time { get; set; }
        public ExamMode Mode { get; set; }
        public int NumOfQues { get; set; }
        public string Subject { get; set; }
        public List<Question> QuestionsTF { get; set; }

        public List<Question> QuestionsMCQ { get; set; }
        public Exam(string subject,int time)
        {
            Subject = subject; 
            Time = time;
            QuestionsTF = new List<Question>();
            QuestionsMCQ = new List<Question>();
        }

        public abstract void Print();

    }
}
