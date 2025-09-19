using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Csharp
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int marks) : base(header, body, marks)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"{Header}\n{Body}\n");

            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}-{Answers[i].Text}");
            }

           

        }
    }
}
