using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day3.Coding
{
    class Divisibilty2
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
                
                if (a % b == 0)
                {
                    Console.WriteLine(c);
                }
                if (a % b != 0)
                {
                    Console.WriteLine(b - (a % b));
                }
            }

        }
    }
}
