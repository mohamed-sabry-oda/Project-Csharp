using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Csharp
{
    internal class Answer
    {
        public string Text{ get; set; } // answer of question

        public bool IsCorrect { get; set; }// to check answer is correct 

        public Answer(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }

        public override string ToString()
        {
            return $"{Text}\n{IsCorrect}";
        }
    }
}
