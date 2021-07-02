using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class Bit
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            int totalCount = 0;

            while (input >= 1)
            {
                string words = Console.ReadLine();

                if (words[0] == '+' || words[2] =='+')
                    totalCount++;
                if (words[0] == '-' || words[2] == '-')
                    totalCount--;
                input--;
            }
            

            Console.WriteLine(totalCount);

        }
    }
}
