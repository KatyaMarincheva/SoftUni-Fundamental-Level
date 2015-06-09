using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using _01.Point3D;

namespace _03.Paths
{
    static class Storage
    {
        private const string PointMatcher = @"(-?\d+),\s+(-?\d+),\s+(-?\d+)";

        public static void LoadPathFromFile(string inputFileLocation)
        {
            StreamReader reader = null;
            StreamWriter writer = null;

            // open input (current) file
            try
            {
                reader = new StreamReader(inputFileLocation, Encoding.GetEncoding("windows-1251"));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

            // create output file
            try
            {
                writer = new StreamWriter(@"..\..\Paths.txt");
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to create output file.");
            }

            int counter = 0;
            string s;
            using (reader)
            using (writer)
            {
                while (true) 
                {
                    s = reader.ReadLine();

                    if (s == null)
                    {
                        break;
                    }

                    // check for 3D paths
                    var pointsInPath = (from Match match in Regex.Matches(s, PointMatcher) 
                                        let xCoordinate = double.Parse(match.Groups[1].Value) 
                                        let yCoordinate = double.Parse(match.Groups[2].Value) 
                                        let zCoordinate = double.Parse(match.Groups[3].Value) 
                                        select new Point3D(xCoordinate, yCoordinate, zCoordinate)).ToList();

                    if (pointsInPath.Count <= 0) continue;

                    // save 3D paths to a new Paths.txt file
                    counter++;
                    var pathFromFile = new Path3D(pointsInPath);
                    writer.WriteLine("Path {0}: {1}", counter, pathFromFile);
                } 
            }
        }
    }
}
