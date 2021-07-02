using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class Watermelon
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if (input != 2 && input % 2 == 0 )
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
        }
    }
}
