using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public class Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);
        private double xCoordinate;
        private double yCoordinate;
        private double zCoordinate;

        public Point3D(double xCoordinate, double yCoordinate, double zCoordinate)
        {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
            this.ZCoordinate = zCoordinate;
        }

        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }
        public double ZCoordinate { get; set; }

        public override string ToString()
        {
            return string.Format("Point: ({0}, {1}, {2})", 
                this.XCoordinate, this.YCoordinate, this.ZCoordinate);
        }
    }
}
