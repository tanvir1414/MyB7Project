using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day6.Generics.Question
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var question = new Question<DT1, DT3>();

            question.DoSomething<DT1, DT2>(new DT2());
        }
    }
}
