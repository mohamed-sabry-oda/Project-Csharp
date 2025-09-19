using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Csharp
{
    internal class FinalExam : Exam
    {
        public FinalExam(string subject, int time) : base(subject, time)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Final Exam: {Subject} - Time: {Time} min");
            foreach (var q in QuestionsTF)
            {
                q.Print();
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            foreach (var q in QuestionsMCQ)
            {
                q.Print();
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
