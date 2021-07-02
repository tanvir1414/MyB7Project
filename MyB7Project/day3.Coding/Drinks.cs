using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day3.Coding
{
    class Drinks
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[input];

            string s = Console.ReadLine();

            string[] word = new string[100];
            word = s.Split(' ');

            double sum = 0.0;
            for (int i = 0; i < input; i++)
            {
                arr[i] = Convert.ToInt32(word[i]);
                sum += arr[i];
            }

            double avg = (sum *1.00000000) / (input * 1.000000000);
            Console.WriteLine(avg);


        }
    }
}
