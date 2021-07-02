using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day3.Coding
{
    class HQ9
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool result = true;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]=='H'|| s[i] == 'Q' || s[i] == '9')
                {
                    Console.WriteLine("YES");
                    result = false;
                    
                    break;
                }

            }
            if(result)
                Console.WriteLine("NO");
        }
    }
}
