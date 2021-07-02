using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day1.Operators
{
    class ExampleOperators
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x++;
            int z = ++x;

            --x;
            x--;

            x += 5;
            x -= 10;

            x = x + 10;
            x = x - 10;
            x = x * 10;
            x = x / 10;
            x = x % 10;

            // 0101010010100101010
            // 1010101010101010101
            //=====================
            int t1 = 5; // 1010
            int t2 = 2; // 010
            int tr = t1 | t2; // 111

            Console.WriteLine(tr);

            int p1 = 5;
            p1 = p1 << 1;
            p1 = p1 >> 1;

            int p = 0xA2;
            int q = 0b_1001_1101;
            int r = p | q;
            Console.WriteLine(Convert.ToString(r, toBase: 2));

        }
    }
}
