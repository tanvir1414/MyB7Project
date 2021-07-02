using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.Coding
{
    //https://codeforces.com/problemset/problem/237/A
    public class FreeCash
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;
            int cash = 0;

            int[,] arr = new int[24,60];

            for (int i = 0; i < input; i++)
            {
                string x = Console.ReadLine();
                string[] words;
                words = x.Split(' ');

                a = Convert.ToInt32(words[0]);
                b = Convert.ToInt32(words[1]);
                arr[a,b]++;

                if (arr[a, b] > cash)
                {
                    cash = arr[a, b];
                }
            }

            Console.Write(cash);
        }
    }
}
