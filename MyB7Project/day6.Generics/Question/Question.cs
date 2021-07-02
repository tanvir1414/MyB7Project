using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day6.Generics.Question
{
    class Question<A, B> where A : class, new()
        where B : DT1
    {
        public M DoSomething<M, N>(N somevalue)
           where N : class
           where M : new()
        {
            if (somevalue == null)
                return default(M);
            else
                return new M();
        }
    }
}
