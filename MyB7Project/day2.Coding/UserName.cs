using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.Coding
{
    //https://codeforces.com/problemset/problem/155/A
    class UserName
    {
        static void Main(string[] args)
        {
            int numberOfInput,i;
            numberOfInput = Convert.ToInt32(Console.ReadLine());

            string point = Console.ReadLine();
            string[] totalPoint= point.Split(' ');
            int[] points  = new int[1000];
            

            for (i=0; i< numberOfInput; i++)
            {
                points[i] = Convert.ToInt32(totalPoint[i]);
            }

            int min = points[0];
            int max = points[0];
            int count = 0;

            for (i = 0; i < numberOfInput; i++)
            {
                if (min > points[i])
                {
                    min = points[i];
                    count++;
                }
                if (max < points[i])
                {
                    max = points[i];
                    count++;
                }
            }
            Console.Write(count);
           
        }
    }
}
