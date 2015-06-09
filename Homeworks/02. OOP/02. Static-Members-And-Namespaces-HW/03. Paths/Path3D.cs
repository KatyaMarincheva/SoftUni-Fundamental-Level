using System.Collections.Generic;
using System.Linq;
using _01.Point3D;

namespace _03.Paths
{
    class Path3D
    {
        // fields
        private List<Point3D> path = new List<Point3D>();

        // constructor
        public Path3D(List<Point3D> path)
        {
            this.Path = path;
        }

        // properties
        public List<Point3D> Path
        {
            get { return this.path; }

            set { this.path = value ?? new List<Point3D>(); }
        }

        // methods
        public void AddPointToPath(Point3D point)
        {
            var currentPath = this.Path;
            currentPath.Add(point);
            this.Path = currentPath;
        }

        public override string ToString()
        {
            return this.Path.Aggregate("\r\n", (current, point) => current + ("\t" + point.ToString() + "\r\n"));
        }
    }
}
