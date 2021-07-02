using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day3.Coding
{
    // https://codeforces.com/problemset/problem/1328/A
    class Divisibilty
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            //string a, b;

            for (int i = 0; i < input; i++)
            {
                long a, b;
                string s = Console.ReadLine();
                string[] nw = new string[2];
                nw = s.Split(' ');
                a = Convert.ToInt64(nw[0]);
                b = Convert.ToInt64(nw[1]);
                long c = 0;
                while (a % b != 0)
                {
                    a++;
                    c++;
                 
                }
                if (a % b == 0)
                {
                    Console.WriteLine(c);
                }
            }
                      
        }
    }
}
