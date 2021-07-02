using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.Coding
{
    public class Football
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] words = input.ToCharArray();

            int count1 = 0;
            int count2 = 0;

            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] == '0')
                {
                    count1++;
                }
                else if (count1 >= 7)
                {
                    break;
                }
                else
                {
                    count1 = 0;
                }

                if (words[i] == '1')
                {
                    count2++;
                }
                else if (count2 >= 7)
                {
                    break;
                }
                else
                {
                    count2 = 0;
                }

            }

            if(count1>=7|| count2 >= 7)
                Console.Write("YES");
            else
                Console.Write("NO");
          
                

        }
    }
}
