using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.Coding
{
    // https://codeforces.com/problemset/problem/118/A
    class String
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();

            input = input.ToLower();

            char[] words = input.ToCharArray();

            string s2 = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == 'a' || words[i] == 'e' || words[i] == 'i' || words[i] == 'o' || words[i] == 'u' || words[i] == 'y')
                {
                    continue;
                }
                else
                {
                    s2 = s2 + '.'.ToString();
                    s2 = s2 + words[i].ToString();

                }
            }

            Console.Write(s2);
               
        }
    }
}
