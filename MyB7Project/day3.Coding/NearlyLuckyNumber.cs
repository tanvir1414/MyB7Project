using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day3.Coding
{
    class NearlyLuckyNumber
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string output = string.Empty;
            string test = input.ToString();

            int count = 0;

            bool result(string test)
            {

                for (int i = 0; i < test.Length; i++)
                {
                    if (test[i] == '4' || test[i] == '7')
                    {
                        count++;
                    }
                }
                if (count ==4||count ==7)
                    return true;
                else
                    return false;
            }

            if (result(input) == true)
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
