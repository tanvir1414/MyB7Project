using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    //https://codeforces.com/problemset/problem/69/A
    class YoungPhysicist
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[100, 3];

            string word;

            string[] words = new string[3];

            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                word = Console.ReadLine();
                words = word.Split(' ');

                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = Convert.ToInt32(words[j]);
                }

            }

            int totalCount1 = 0;
            int totalCount2 = 0;
            int totalCount3 = 0;


            for (int i = 0; i < n; i++)
            {

                    if (arr[i,0]!=0)
                    {
                        totalCount1 += arr[i, 0];
                    }
                    if (arr[i, 1] != 0)
                    {
                        totalCount2 += arr[i, 1];
                    }
                    if (arr[i, 2] != 0)
                    {
                        totalCount3 += arr[i, 2];
                    }

            }

            if (totalCount1 == 0 && totalCount2 == 0 && totalCount3 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
