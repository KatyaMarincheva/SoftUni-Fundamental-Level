using System;
using System.Globalization;
using System.Threading;

namespace _02.LaptopShop
{
    class LaptopShopMain
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            // 1st test option:
            // You can run the Unit Tests from the Visual Studio menu: 
            // BUILD -> Build Solution
            // TEST -> Windows -> Test Explorer (you will see in the Test Explorer window: Not Run Tests or Passed Tests
            // and above it:  Run All
            // Please, click on Run All, and read the ClassLaptopTests.cs file for more details

            // 2nd test option: Ctrl + F5 
            // test object creation with full info
            var laptopWithFullInfo = new Laptop(
                "Lenovo Yoga 2 Pro",
                "Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "Intel HD Graphics 4400",
                "128GB SSD",
                "13.3 inches (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display)",
                new Battery("Li-Ion", 4, 2550, 4.5),
                2259.00m);

            Console.WriteLine(laptopWithFullInfo);

            // test object creation with mandatory info
            var laptopWithMandatoryInfoOnly = new Laptop("HP 250 G2", 699.00m);

            Console.WriteLine(laptopWithMandatoryInfoOnly);
        }
    }
}
