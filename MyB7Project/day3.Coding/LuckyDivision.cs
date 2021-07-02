using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day3.Coding
{
    //https://codeforces.com/problemset/problem/122/A
    class LuckyDivision
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            string output = string.Empty;
            string test = input.ToString();

            bool result(int input)
            {

                for (int i = 0; i < test.Length; i++)
                {
                    if (test[i] == '4' || test[i] == '7')
                    {
                        output += test[i];
                    }
                }
                if (output == test)
                    return true;
                else
                    return false;
            }

            if (result(input) == true)
            {
                Console.WriteLine("YES");
            }
            else if (input % 4 == 0 || input % 7 == 0 || input % 47 == 0 || input %744 ==0 )
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
