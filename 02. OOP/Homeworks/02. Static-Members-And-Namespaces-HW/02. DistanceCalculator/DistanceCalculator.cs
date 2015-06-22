using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D a, Point3D b)
        {
            var deltaX = a.XCoordinate - b.XCoordinate;
            var deltaY = a.YCoordinate - b.YCoordinate;
            var deltaZ = a.ZCoordinate - b.ZCoordinate;

            var distance = Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
            return distance;
        }
    }
}
