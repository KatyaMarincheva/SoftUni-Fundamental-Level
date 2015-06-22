/* Problem 2. Laptop Shop
Define a class Laptop that holds the following information about a laptop device: model, manufacturer, processor, 
 * RAM, graphics card, HDD, screen, battery, battery life in hours and price.
•	The model and price are mandatory. All other values are optional.
•	Define two separate classes: a class Laptop holding an instance of class Battery.
•	Define several constructors that take different sets of arguments (full laptop + battery information or only part of it). 
 * Use proper variable types.
•	Add a method in the Laptop class that displays information about the given instance
o	Tip: override the ToString() method
•	Put validation in all property setters and constructors. String values cannot be empty, and numeric data cannot be negative. 
 * Throw exceptions when improper data is entered.
 */

namespace _02.LaptopShopMain
{
    using System;
    using LaptopShop;

    internal class LaptopShopMain
    {
        internal static void Main()
        {
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
                2259.00m,
                "Lenovo",
                "13.3 inches (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display)",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "128GB SSD",
                "Intel HD Graphics 4400",
                new Battery("Li-Ion", 4, 2550, 4.5));

            Console.WriteLine(laptopWithFullInfo);

            // test object creation with mandatory info
            var laptopWithMandatoryInfoOnly = new Laptop("HP 250 G2", 699.00m);

            Console.WriteLine(laptopWithMandatoryInfoOnly);
        }
    }
}
