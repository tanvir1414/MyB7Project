using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class LongWords
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            

            while (input > 0)
            {
                string word = Console.ReadLine();

                int wordLenght = word.Length;
                int wordMiddle = word.Length - 2;

                if (wordLenght <= 10)
                {
                    Console.WriteLine(word);
                }
                else
                {
                    string finalResult = word.Substring(0, 1) + wordMiddle + word.Substring(wordLenght - 1, 1);
                    Console.WriteLine(finalResult);
                }

                input--;
            }
        
        }
    }
}
