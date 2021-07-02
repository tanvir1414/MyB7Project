using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day2.Coding
{
    // https://codeforces.com/problemset/problem/43/A
    class FootballWinner
    {
        static void Main(string[] args)
        {
            int input;
            int i;
            input = Convert.ToInt32(Console.ReadLine());
            string[] team = new String[100];

            int teamGoal1=0, teamGoal2=0;
            string temp = string.Empty;


            for (i = 0; i < input; i++)
            {
                team[i] = Console.ReadLine();
                if (i == 0)
                    teamGoal1++;
                if (String.Equals(team[0], team[i]))
                {
                    teamGoal1++;
                }
                else //if (team[0] != team[i])
                {
                    temp = team[i];
                    teamGoal2++;
                }

            }

            if (teamGoal1 > teamGoal2)
            {
                Console.WriteLine(team[0]);
            }
            else //if (String.Equals(team[0], team[i]))
            {
                //for (i = 0; i < input; i++)
                //{

                //    if (!String.Equals(team[0], team[i]))
                //    {
                //        Console.WriteLine(team[i]);
                //        break;
                //    }
                //}
                Console.WriteLine(temp);
            }
        }
    }
}
