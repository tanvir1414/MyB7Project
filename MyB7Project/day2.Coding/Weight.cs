using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.Coding
{
    class Weight
    {
        static void Main(string[] args)
        {
            int a, b, i = 1;
            string x = Console.ReadLine();
            string[] words;
            words = x.Split(' ');

            //foreach (var word in words)
            //{
            //    a = word[0];
            //    b = word[1];
            //}
           a = Convert.ToInt32(words[0]);
           b = Convert.ToInt32(words[1]);
            for(; ; i++)
            {
                a *= 3;
                b *= 2;
                if (a > b)
                {
                    break;
                }
            }
            Console.Write(i);
        }
    }
}
