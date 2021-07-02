using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    //https://codeforces.com/problemset/problem/703/A
    class MishaGame
    {
        static void Main(string[] args)
        {
            int numofGame = Convert.ToInt32(Console.ReadLine());

            string[] words = new string[2];
            int[,] arr = new int[100,2];

            int countMisha = 0;
            int countChris = 0;

            for (int i = 0; i < numofGame; i++)
            {
                string newWord = Console.ReadLine();
                words = newWord.Split(' ');

                arr[i, 0] = Convert.ToInt32(words[0]);
                arr[i, 1] = Convert.ToInt32(words[1]);

                if (arr[i, 0] > arr[i, 1])
                {
                    countMisha++;
                }
                if (arr[i, 0] < arr[i, 1])
                {
                    countChris++;
                }
            }

            if (countMisha > countChris)
            {
                Console.WriteLine("Mishka");
            }
            else if (countChris > countMisha)
            {
                Console.WriteLine("Chris");
            }
            else
            {
                Console.WriteLine("Friendship is magic!^^");
            }
        }
    }
}
