using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class DominoPiling
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] word = new string[2];

            word = input.Split(' ');

            int a = Convert.ToInt32(word[0]);
            int b = Convert.ToInt32(word[1]);

            int result = (a * b) / 2;
            Console.WriteLine(result);
        }
    }
}
