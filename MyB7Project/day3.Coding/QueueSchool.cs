using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day3.Coding
{
    // https://codeforces.com/problemset/problem/266/B
    class QueueSchool
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();
            
            string[] word = new string[2];
            word = arr.Split(' ');

            int a = Convert.ToInt32(word[0]);
            int b = Convert.ToInt32(word[1]);

            string arr1 = Console.ReadLine();
            char[] s = arr1.ToCharArray();

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a-1; j++)
                {
                    if (s[j] == 'B' && s[j+1] == 'G')
                    {
                        s[j] = 'G';
                        s[j+1] = 'B';
                        j++;
                    }
                }
            }

            Console.WriteLine(s);
        }
    }
}
