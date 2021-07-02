using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class Word
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] words = input.ToCharArray();

            int totalUpper = 0;
            int totalLower = 0;
            

            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsUpper(words[i]))
                {
                    totalUpper++;
                }
                else
                {
                    totalLower++;
                }      
            }

            if (totalUpper > totalLower)
            {
                Console.WriteLine(input.ToUpper());
            }
            else {
                Console.WriteLine(input.ToLower());
            }
           

        }
    }
}
