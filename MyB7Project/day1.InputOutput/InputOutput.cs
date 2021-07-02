using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day1.InputOutput
{
    class InputOutput
    {
        static void Main(string[] args)
        {
            
          string line = Console.ReadLine();

          while (true)
          {
              int charVal = Console.Read();
              char c = (char)charVal;
              Console.Write(c);
          }

          ConsoleKeyInfo key = Console.ReadKey();

          Console.WriteLine("Hello World!");
          

            /*
            var line = Console.ReadLine();
            int number = int.Parse(line);

            line = Console.ReadLine();
            int anotherNumber = int.Parse(line);

            var sum = number + anotherNumber;

            Console.WriteLine(sum);
            */

            /*
            var invalidFormat = Console.ReadLine();
            int valiNumber;

            bool isSuccessfulyConverted = int.TryParse(invalidFormat, out valiNumber);
            */

            //var line = Console.ReadLine();
            //var lineParts = line.Split(',');

            //var wholeNumber = int.Parse(lineParts[0].Trim());
            //var fractionNumber = double.Parse(lineParts[1].Trim());

        }
    }
}
