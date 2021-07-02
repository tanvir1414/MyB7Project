using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class BeautifulMatrix
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5,5];
            string word;
            
            string[] words = new string[5];

            int row = 0;
            int column = 0;

            
            for (int i = 0; i < 5; i++)
            {
                word = Console.ReadLine();
                words = word.Split(' ');

                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = Convert.ToInt32(words[j]);
                    if (arr[i, j] == 1)
                    {
                        row = i;
                        column = j;
                    }
                }

            }

            int totalCount = Math.Abs(2-row) + Math.Abs(2-column);

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(arr[i,j] +" ");
            //    }
            //    Console.WriteLine();

            //}

            Console.WriteLine(totalCount);

        }
    }
}
