// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MethodsUnitTests.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The methods unit tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MethodsUnitTests
{
    using System;
    using Methods.Method_Classes;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The methods unit tests.
    /// </summary>
    [TestClass]
    public class MethodsUnitTests
    {
        /// <summary>
        /// Tests the CalculateTriangleArea method when one or more arguments are negative_ should throw argument exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateTriangleArea_WhenOneOrMoreArgumentsAreNegative_ShouldThrowArgumentException()
        {
            Calculations.CalculateTriangleArea(-1, 4, 5);
        }

        /// <summary>
        /// Tests the CalculateTriangleArea method when all arguments are valid - should pass test.
        /// </summary>
        [TestMethod]
        public void CalculateTriangleArea_WhenAllArgumentsAreValid_ShouldPassTest()
        {
            Calculations.CalculateTriangleArea(6, 4, 5);
        }

        /// <summary>
        /// Tests the FindMax method when the input array is empty - should throw argument null exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindMax_WhenTheInputArrayIsEmpty_ShouldThrowArgumentNullException()
        {
            Calculations.FindMax();
        }

        /// <summary>
        /// Tests the FindMax method when the input array is not empty - should pass test.
        /// </summary>
        [TestMethod]
        public void FindMax_WhenTheInputArrayIsNotEmpty_ShouldPassTest()
        {
            Calculations.FindMax(5, -1, 3, 2, 14, 2, 3);
        }

        /// <summary>
        /// Tests the CalculateDistance method - should pass test.
        /// </summary>
        [TestMethod]
        public void CalculateDistance_ShouldPassTest()
        {
            const double Expected = 3.5;
            double actual = Calculations.CalculateDistance(3, -1, 3, 2.5);

            Assert.AreEqual(Expected, actual);
        }

        /// <summary>
        /// Checks if the line crossing the two given points is horizontal - should pass test.
        /// </summary>
        [TestMethod]
        public void IsHorizontalLine_ShouldPassTest()
        {
            const bool Expected = true;
            bool actual = Calculations.IsHorizontalLine(3, 3);

            Assert.AreEqual(Expected, actual);
        }

        /// <summary>
        /// Checks if the line crossing the two given points is vertical - should pass test.
        /// </summary>
        [TestMethod]
        public void IsVerticalLine_ShouldPassTest()
        {
            const bool Expected = false;
            bool actual = Calculations.IsVerticalLine(-2, 2);

            Assert.AreEqual(Expected, actual);
        }

        /// <summary>
        /// Tests the PrintDigitAsWord method when the input is valid - should pass test.
        /// </summary>
        [TestMethod]
        public void PrintDigitAsWord_ShouldPassTest()
        {
            const string Expected = "four";
            string actual = Formatting.PrintDigitAsWord(4);

            Assert.AreEqual(Expected, actual);
        }

        /// <summary>
        /// Tests the PrintDigitAsWord method when the input is not a digit - should return error message.
        /// </summary>
        [TestMethod]
        public void PrintDigitAsWord_WhenTheInputIsNotADigit_ShouldReturnErrorMessage()
        {
            const string Expected = "Not a digit!";
            string actual = Formatting.PrintDigitAsWord(42);

            Assert.AreEqual(Expected, actual);
        }

        /// <summary>
        /// Tests the FormatNumber method when format string is invalid should throw argument exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FormatNumber_WhenFormatStringIsInvalid_ShouldThrowArgumentException()
        {
            Formatting.FormatNumber(2, "Y");
        }

        /// <summary>
        /// Tests the FormatNumber method when format string is valid should pass test.
        /// </summary>
        [TestMethod]
        public void FormatNumber_WhenFormatStringIsValidShouldPassTest()
        {
            Formatting.FormatNumber(2, "F");
        }
    }
}