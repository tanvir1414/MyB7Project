using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day1.ControlStatements
{
    class ExampleControl
    {
        static void Main(string[] args)
        {

            int x = 5;
            /*
            if(x >= 5)
            {
                Console.WriteLine("Big number");
            }
            else
            {
                Console.WriteLine("Small number");
            }
            */

            if (x == 5)
            {
                Console.WriteLine("x is 5");
            }
            else if (x > 5 && x <= 100 || x > 1000)
            {
                Console.WriteLine("Big number");
            }
            else if (x < 5 && x != 0)
            {
                Console.WriteLine("Small number");
            }
            else
            {
                Console.WriteLine("I am confused");
            }


            switch (x)
            {
                case 1:
                    Console.WriteLine("Turning on engine");
                    break;
                case 2:
                    Console.WriteLine("Increaing speed");
                    break;
                case 3:
                    Console.WriteLine("Turning off engine");
                    break;
                default:
                    Console.WriteLine("Removing key");
                    break;
            }


            // ? : 
            string message = x > 5 ? "big number" : "small number";

        }
    }
}
