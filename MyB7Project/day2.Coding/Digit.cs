using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.Coding
{
    //https://codeforces.com/problemset/problem/616/A
    class Digit
    {

        static void Main(string[] args)
        {
            uint a,b;

            a = Convert.ToUInt32(Console.ReadLine());
            b = Convert.ToUInt32(Console.ReadLine());

            if(a == b)
                Console.Write("=");
            else if (a > b)
            {
                Console.Write(">");
            }
            else
            {
                Console.Write("<");
            }
        }
    }
}
