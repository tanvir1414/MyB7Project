using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.Coding
{
    class Binary
    {
        static void Main(string[] args)
        {
            int a, i = 1;
            string b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Console.ReadLine();

            char[] words = b.ToCharArray();
            int zero = 0;
            int one = 1;

            for (i = 0; i < words.Length; i++)
            {
                if (words[i] == 'n')
                {
                    one++;
                    Console.Write("1 ");
                }
                    
                if (words[i] == 'z')
                    zero++;
            }

            for (i = 0; i < zero; i++)
            {
                Console.Write("0 ");
            }
        }
    }
}
