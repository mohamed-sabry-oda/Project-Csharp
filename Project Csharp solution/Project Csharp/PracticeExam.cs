using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Csharp
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(string subject, int time) : base(subject, time)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Practice Exam: {Subject} - Time: {Time} min");
            foreach (var q in QuestionsTF)
            {
                q.Print();
                int choice = int.Parse(Console.ReadLine());

                if (q.Answers[choice - 1].IsCorrect)
                {
                    Console.WriteLine("Correct Answer");
                }
                else
                {
                    Console.WriteLine($"Wrong Answer. Correct is: {q.Answers.First(a => a.IsCorrect).Text}");
                }
            }
            foreach (var q in QuestionsMCQ)
            {
                q.Print();
                int choice = int.Parse(Console.ReadLine());

                if (q.Answers[choice - 1].IsCorrect)
                {
                    Console.WriteLine("Correct Answer");
                }
                else
                {
                    Console.WriteLine($"Wrong Answer. Correct is: {q.Answers.First(a => a.IsCorrect).Text}");
                }
            }
        }
    }
}
