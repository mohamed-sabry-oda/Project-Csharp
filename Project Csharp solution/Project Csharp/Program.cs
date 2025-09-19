using System;

namespace Project_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello!");

            Console.WriteLine("Choose Exam Type (1-Practice, 2-Final): ");
            int choice = int.Parse(Console.ReadLine());

            Exam exam;
            if (choice == 1)
                exam = new PracticeExam("OOP", 30);
            else
                exam = new FinalExam("OOP", 30);

            // Add Questions
            var q1 = new TFQuestion("Q1", "C# is an OOP Language?", 5);
            q1.Answers.Add(new Answer("True", true));
            q1.Answers.Add(new Answer("False", false));


            var q2 = new MCQQuestion("Q2", "Which are .NET Languages?", 10);
            q2.Answers.Add(new Answer("C#", false));
            q2.Answers.Add(new Answer("Java", false));
            q2.Answers.Add(new Answer("VB.NET", false));
            q2.Answers.Add(new Answer("Python", false));
            q2.Answers.Add(new Answer("C# and VB.NET", true));

            exam.QuestionsTF.Add(q1);
            exam.QuestionsMCQ.Add(q2);

            // Show Exam
            exam.Print();
        }
    }
}
