using System;
using System.IO;

namespace _03.Paths
{
    class PathsMain
    {

        static void Main()
        {
            // load 3D paths from file, and save them to a Paths.txt file
            Storage.LoadPathFromFile(@"..\..\text.txt");

            // print output file to the console
            var fileContents = File.ReadAllText(@"..\..\Paths.txt");
            Console.WriteLine(fileContents);
        }
    }
}
