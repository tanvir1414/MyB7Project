using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.Coding
{
    class CapsLock
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.ToLower();
            string newWord = word;
            newWord = newWord.ToUpper();

            Console.Write(newWord.Substring(0,1)+word.Substring(1));

            char[] words = word.ToCharArray();

        }
    }
}
