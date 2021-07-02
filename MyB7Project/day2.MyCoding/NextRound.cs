using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class NextRound
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string[] newWord = new string[2];

            newWord = word.Split(' ');

            int n = Convert.ToInt32(newWord[0]);
            int k = Convert.ToInt32(newWord[1]);

            string input = Console.ReadLine();
            int[] a = new int[100];
            string[] b = new string[2];
            b = input.Split(' ');

            for (int i = 0; i < n; i++)
            {
                a[i]= Convert.ToInt32(b[i]);
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0 && a[i] >= a[k-1])
                {
                    count++;
                }
                
            }

            Console.WriteLine(count);
            
        }
    }
}
