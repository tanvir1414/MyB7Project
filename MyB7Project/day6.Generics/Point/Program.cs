using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day6.Generics.Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D<int> pointA = new Point3D<int>();
            pointA.x = 10;
            pointA.y = 20;
            pointA.z = 30;

            var result = pointA.x + pointA.y;
        }
    }
}
