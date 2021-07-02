using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day1.Array
{
    class ExampleArrays
    {
        static void Main(string[] args)
        {
             int[][,] jaggedArray4 = new int[][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };

            for (int i = 0; i < jaggedArray4.Length; i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < jaggedArray4[i].GetLength(0); j++)
                {
                    Console.Write("{ ");

                    for (int k = 0; k < jaggedArray4[j].Rank; k++)
                    {
                        Console.Write(jaggedArray4[i][j, k] + ",");
                    }
                    Console.Write(" }");
                }
                Console.Write(" }");
                Console.WriteLine();
            }
        }
    }
}
