using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day3.Coding
{
    //https://codeforces.com/problemset/problem/158/B
    // Wrong answer 37
    class Taxi
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[input];

            string s = Console.ReadLine();

            string[] word = new string[input];
            word = s.Split(' ');

            double sum = 0.0;
            for (int i = 0; i < input; i++)
            {
                arr[i] = Convert.ToInt32(word[i]);
                sum += arr[i];
            }

            
            double avg = Math.Ceiling((sum * 1.00000000) / (4));

            Console.WriteLine(avg);
        }
    }
}
