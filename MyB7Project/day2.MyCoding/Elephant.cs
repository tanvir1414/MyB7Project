using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class Elephant
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            double result = input / 5;

            if(input % 5 == 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result+1);
            }

            
        }
    }
}
