using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day3.Coding
{
    class CalculateFunction
    {
        static void Main(string[] args)
        {
            long l = Convert.ToInt64(Console.ReadLine());

            if (l % 2 == 0)
            {
                Console.WriteLine(l/2);
            }
            else
            {
               // l = -(l / 2 + 1);
                Console.WriteLine(-(l / 2 + 1));
            }
        }
    }
}
