using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class BoyOrGirl
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] frequency = new int[27];
            int totalCount = 0;

            foreach (char x in input)
            {
                int v = x;
                frequency[v-97]++;
            }

            for (int i = 0; i < 27; i++)
            {
                if (frequency[i] != 0)
                    totalCount++;
            }

            if(totalCount % 2 == 0)
                Console.WriteLine("CHAT WITH HER!");
            else
                Console.WriteLine("IGNORE HIM!");
            
        }
    }
}
