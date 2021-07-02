using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day1.Array
{
    public class ExampleArray
    { 
        static void Main(string[] args)
        {
            int[] ages = new int[20];
            ages = new int[30];
            ages[0] = 23;
            ages[1] = 33;
            ages[2] = 32;
            ages[19] = 36;

            int[,] board = new int[20, 20];
            board[0, 0] = 1;
            board[0, 1] = 3;
            board[2, 2] = 5;
            int temp = board[2, 3];

            int[,,] cube = new int[20, 20, 20];
            cube[3, 3, 4] = 9;

            int[][] jagged2D = new int[20][];
            jagged2D[0] = new int[10];
            jagged2D[1] = new int[20];

            
            jagged2D[1][2] = 5;


            int[][][] jagged3D = new int[20][][];
            jagged3D[0] = new int[20][];
            jagged3D[1] = new int[10][];

            jagged3D[1][1] = new int[5];


            int[] setValue1 = new int[] { 10, 20, 30 };
            int aa = setValue1[0]; // value 10
            int aaa = setValue1[1];

            int[,] setValue2 = new int[,]
            {
            { 10, 20 },
            { 30, 40 }
            };
            int bb = setValue2[0, 0];
            int bbb = setValue2[1, 1];

            
        }
    }

}

