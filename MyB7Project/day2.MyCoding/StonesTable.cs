using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class StonesTable
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            string word = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
           
        }
    }
}
