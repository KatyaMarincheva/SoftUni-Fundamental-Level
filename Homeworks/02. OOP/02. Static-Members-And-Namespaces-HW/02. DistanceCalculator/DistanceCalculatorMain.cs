using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    class DistanceCalculatorMain
    {
        static void Main()
        {
            var point1 = Point3D.StartingPoint;
            var point2 = new Point3D(1, 1, 1);

            var distance = DistanceCalculator.CalculateDistance(point1, point2);
            Console.WriteLine(distance);
        }
    }
}
