using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Csharp
{
    internal class TFQuestion : Question
    {
        public TFQuestion(string header,string body,int marks): base(header,body,marks) { }

        public override void Print()
        {
            Console.WriteLine($"{Header}\n{Body}\n1-True\n2-False");
            
        }
    }
}
