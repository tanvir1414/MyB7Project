using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day5.Turples
{
    class ExampleTurples
    {
        static void Main(string[] args)
        {
            var result = CalculateAverages(2, 3, 4, 5);

            Console.WriteLine(result.a);
            Console.WriteLine(result.Item2);


            (int x, int y)[] pairs = new (int x, int y)[10];

            pairs[0].x = 10;
            pairs[0].y = 20;

            pairs[1].x = 20;
            pairs[1].y = 30;

            (string name, int age)[] person = new (string name, int age)[10];

            person[0].name = "Tanvir";
            person[0].age = 18;
        }

        public static (int a, double b ) CalculateAverages(params int []numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return (sum / numbers.Length, sum * 1.0 / numbers.Length);
        }
            
    }
}
