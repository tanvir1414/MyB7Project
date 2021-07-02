using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class SoldiersAndBanana
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = new string[2];
            words = input.Split(' ');

            int k, n, w;
            k = Convert.ToInt32(words[0]);
            n = Convert.ToInt32(words[1]);
            w = Convert.ToInt32(words[2]);

            int totalCost = 0;
            for (int i = 1; i <= w; i++)
            {
                totalCost += k * i;
            }
            
            //1 2 1=-1
            
            int debt = totalCost - n;
            if (debt > 0)
            {
                Console.WriteLine(debt);
            }
            else
                Console.WriteLine(0);


        }
    }
}
