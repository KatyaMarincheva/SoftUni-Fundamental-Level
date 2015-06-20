namespace ClassLaptopTests
{
    using System;
    using _02.LaptopShop;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ClassLaptopTests
    {
        // We use the ExpectedExceptionAttribute attribute to assert that the right exception has been thrown. 
        // The attribute causes the test to fail unless an ArgumentNullException is thrown.
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Model_WhenModelIsEmpty_ShouldThrowArgumentNullException()
        {
            var laptopWithEmptyModel = new Laptop(string.Empty, 699.00m);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Price_WhenPriceIsNegative_ShouldThrowArgumentOutOfRangeException()
        {
            var laptopWithEmptyModel = new Laptop("HP 250 G2", -699.00m);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BatteryType_WhenBatteryTypeIsEmpty_ShouldThrowArgumentNullException()
        {
            var laptopWithFullInfo = new Laptop(
                "Lenovo Yoga 2 Pro",
                2259.00m,
                "Lenovo",
                "13.3 inches (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display)",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "128GB SSD",
                "Intel HD Graphics 4400",
                new Battery(string.Empty, 4, 2550, 4.5));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BatteryNumberOfCells_WhenBatteryNumberOfCellsIsNegative_ShouldThrowArgumentOutOfRangeException()
        {
            var laptopWithFullInfo = new Laptop(
                "Lenovo Yoga 2 Pro",
                2259.00m,
                "Lenovo",
                "13.3 inches (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display)",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "128GB SSD",
                "Intel HD Graphics 4400",
                new Battery("Li-Ion", -4, 2550, 4.5));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BatteryCapacity_WhenBatteryCapacityIsNegative_ShouldThrowArgumentOutOfRangeException()
        {
            var laptopWithFullInfo = new Laptop(
                "Lenovo Yoga 2 Pro",
                2259.00m,
                "Lenovo",
                "13.3 inches (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display)",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "128GB SSD",
                "Intel HD Graphics 4400",
                new Battery("Li-Ion", 4, -2550, 4.5));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BatteryLife_WhenBatteryLifeIsNegative_ShouldThrowArgumentOutOfRangeException()
        {
            var laptopWithFullInfo = new Laptop(
                "Lenovo Yoga 2 Pro",
                2259.00m,
                "Lenovo",
                "13.3 inches (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display)",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "128GB SSD",
                "Intel HD Graphics 4400",
                new Battery("Li-Ion", 4, 2550, -4.5));
        }

        [TestMethod]
        public void Laptop_LaptopWithFullInfo_ShouldPassTest()
        {
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
        }

        [TestMethod]
        public void Laptop_LaptopWithMandatoryInfoOnly_ShouldPassTest()
        {
            var laptopWithMandatoryInfoOnly = new Laptop("HP 250 G2", 699.00m);
        }
    }
}
