namespace ClassComputerTests
{
    using System;
    using System.Collections.Generic;
    using _03.PC_Catalog;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ClassComputerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Name_ComputerWithEmptyName_ShouldThrowArgumentNullException()
        {
            var componentsList = new List<Component>();
            componentsList.Add(new Component("HDD", 90));

            var pc = new Computer(string.Empty, componentsList);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ComponentsList_ComputerWithEmptyComponentsList_ShouldThrowArgumentNullException()
        {
            var componentsList = new List<Component>();

            var pc = new Computer("HP", componentsList);
        }

        [TestMethod]
        public void Computer_ComputerWithValidInfo_ShouldPassTest()
        {
            var componentsList = new List<Component>();
            componentsList.Add(new Component("HDD", 90));

            var pc = new Computer("HP", componentsList);
        }

        [TestMethod]
        public void CompareToMethod_CorrectlyComparesComputers()
        {
            // arrange
            var componentsList1 = new List<Component>();
            componentsList1.Add(new Component("HDD", 90));
            componentsList1.Add(new Component("RAM", 120));
            var pc1 = new Computer("HP", componentsList1);

            var componentsList2 = new List<Component>();
            componentsList2.Add(new Component("HDD", 190));
            componentsList2.Add(new Component("RAM", 160));
            var pc2 = new Computer("Dell", componentsList1);

            var expected = pc1.Price.CompareTo(pc2.Price);

            // assert - if equal, the computers have indeed been compared by price
            var actual = pc1.CompareTo(pc2);
            Assert.AreEqual(expected, actual, "Computers were not correctly compared.");
        }
    }
}
