﻿using System;
using System.Collections.Generic;

namespace _03.PC_Catalog
{
    class PCCatalogMain
    {
        static void Main()
        {            
            // 1st test option:
            // You can run the Unit Tests from the Visual Studio menu: 
            // BUILD -> Build Solution
            // TEST -> Windows -> Test Explorer (you will see in the Test Explorer window: Not Run Tests or Passed Tests
            // and above it:  Run All
            // Please, click on Run All, and read the ClassComponentTests.cs and the ClassComputerTests.cs files for more details

            // 2nd test option: Ctrl + F5 

            // start catalog
            var catalog = new List<Computer>();

            // 1st computer
            var componentsList1 = new List<Component>();
            componentsList1.Add(new Component("Motherboard", 90));
            componentsList1.Add(new Component("CPU", 120.45m));
            componentsList1.Add(new Component("RAM", 45.50m, "8 GB"));

            // adding additional component to already created Computer object
            var pc = new Computer("HP", componentsList1);
            Console.WriteLine(pc);
            pc.AddComponent(new Component("added later", 126)); // Using method that allows addition of components
            Console.WriteLine(pc);

            catalog.Add(pc);

            // 2nd computer
            var componentsList2 = new List<Component>();
            componentsList2.Add(new Component("DVD", 15.99m));
            componentsList2.Add(new Component("GPU", 255.1m));

            catalog.Add(new Computer("Cheap", componentsList2));

            // 3rd computer
            var componentsList3 = new List<Component>();
            componentsList3.Add(new Component("RAM", 52.19m));
            componentsList3.Add(new Component("SSD", 550));

            catalog.Add(new Computer("Average", componentsList3));

            // 4th computer
            var componentsList4 = new List<Component>();
            componentsList4.Add(new Component("GPU", 1125.5m));
            componentsList4.Add(new Component("CPU", 900));

            catalog.Add(new Computer("Expensive", componentsList4));


            catalog.Sort(); // IComparable interface implemented on Computer class
            Console.WriteLine("\r\n" + new string('-', 50) + "\r\n" + "COMPUTER CATALOG");
            foreach (var computer in catalog)
            {
                Console.WriteLine(computer);
            }
        }
    }
}