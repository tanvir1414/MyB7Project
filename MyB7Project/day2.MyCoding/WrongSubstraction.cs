using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    //https://codeforces.com/problemset/problem/977/A
    class WrongSubstraction
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = new string[2];
            words = input.Split(' ');

            int a = Convert.ToInt32(words[0]);
            int b = Convert.ToInt32(words[1]);

            int x = a % 10;
            while (b > 0)
            {
                while (a % 10 != 0 && b > 0)
                {
                    a--;
                    b--;
                    
                }

                while (a % 10 == 0 && b > 0)
                {
                    a = a / 10;
                    b--;
                }
            }

            Console.WriteLine(a);
           
        }
    }
}
