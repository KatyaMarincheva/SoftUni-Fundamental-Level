using System;

namespace _01.Point3D
{
    class Point3DMain
    {
        static void Main()
        {
            // creating two points
            var point1 = new Point3D(1, 1, 1);
            var point2 = new Point3D(2.4, 2.4, 2.4);
            Console.WriteLine(point1);
            Console.WriteLine(point2);

            // setting the third point to be equal to the starting point constant
            var x = Point3D.StartingPoint;
            Console.WriteLine(x);
        }
    }
}
