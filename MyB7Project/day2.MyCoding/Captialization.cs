using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class Captialization
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.Substring(0, 1).ToUpper() + word.Substring(1);
            Console.WriteLine(word);
        }
    }
}
