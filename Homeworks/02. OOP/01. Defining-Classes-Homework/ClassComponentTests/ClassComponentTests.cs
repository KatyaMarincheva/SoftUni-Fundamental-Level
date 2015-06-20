namespace ClassComponentTests
{
    using System;
    using System.Collections.Generic;
    using _03.PC_Catalog;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ClassComponentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Price_ComponentWithNegativePrice_ShouldThrowArgumentOutOfRangeException()
        {
            var componentsList = new List<Component>();
            componentsList.Add(new Component("Motherboard", -90));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Name_ComponentWithEmptyName_ShouldThrowArgumentNullException()
        {
            var componentsList = new List<Component>();
            componentsList.Add(new Component(string.Empty, 90));
        }

        [TestMethod]
        public void Component_ComponentWithMandatoryInfoOnly_ShouldPassTest()
        {
            var componentsList = new List<Component>();
            componentsList.Add(new Component("Motherboard", 90));
        }

        [TestMethod]
        public void Component_ComponentWithAllInfo_ShouldPassTest()
        {
            var componentsList = new List<Component>();
            componentsList.Add(new Component("RAM", 45.50m, "8 GB"));
        }

        [TestMethod]
        public void CompareToMethod_CorrectlyComparesComponents()
        {
            // arrange
            var component1 = new Component("RAM", 45.50m, "8 GB");
            var component2 = new Component("Motherboard", 90);
            var expected = component1.Price.CompareTo(component2.Price);

            // assert - if equal, the components have indeed been compared by price
            var actual = component1.CompareTo(component2);
            Assert.AreEqual(expected, actual, "Components were not correctly compared.");
        }
    }
}
