using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class Team
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int totalCount = 0;

            for(int i=0; i<input; i++)
            {
                string word = Console.ReadLine();
                string[] newWord = new string[3];
                newWord = word.Split(' ');

                int a, b, c;

                a = Convert.ToInt32(newWord[0]);
                b = Convert.ToInt32(newWord[1]);
                c = Convert.ToInt32(newWord[2]);

                int[] count = new int[1000];
                if (a == 1)
                {
                    count[i]++;
                }
                if (b == 1)
                {
                    count[i]++;
                }
                if (c == 1)
                {
                    count[i]++;
                }

                if (count[i] >= 2)
                    totalCount++;

            }

            Console.WriteLine(totalCount);
            
        }
    }
}
