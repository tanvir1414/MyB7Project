using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.MyCoding
{
    class HelpfulMaths
    {
        static void Main(string[] args)
        {
            string u = Console.ReadLine();
            int[] arr = new int[100];

            string[] words = new string[100];
            words = u.Split('+');

            for (int i = 0; i < words.Length; i++)
            {               
                arr[i] = Convert.ToInt32(words[i]);
                if (arr[i] == 0)
                    break;
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Sorting array

            int c, d, swap;
            for (c = 0; c < arr.Length - 1; c++)
            {
                for (d = 0; d < arr.Length - c - 1; d++)
                {
                    if (arr[d] > arr[d + 1]) 
                    {
                        swap = arr[d];
                        arr[d] = arr[d + 1];
                        arr[d + 1] = swap;
                    }
                }
            }

            for (c = 0; c < arr.Length; c++)
            {
                if (arr[c] == 0)
                    continue;
               
                Console.Write(arr[c]);
                try
                {
                    if (arr[c + 1] != 0)
                        Console.Write('+');
                }
                catch(Exception ex)
                {

                }
                
            }

        }
    }
}
