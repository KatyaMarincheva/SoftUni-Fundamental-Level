namespace ClassInterestCalculatorTests
{
    using System;
    using _02.Interest_Calculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ClassInterestCalculatorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Interest_WhenInterestIsNegative_ShouldThrowArgumentOutOfRangeException()
        {
            InterestCalculator compoundInterest = new InterestCalculator(500m, -0.056m, 10, InterestCalculatorMain.GetCompoundInterest);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Years_WhenYearsAreNegative_ShouldThrowArgumentOutOfRangeException()
        {
            InterestCalculator simpleInterest = new InterestCalculator(2500m, 0.072m, -15, InterestCalculatorMain.GetSimpleInterest);
        }

        [TestMethod]
        public void InterestCalculator_WithAllArgumentsValid_ShouldPassTest()
        {
            InterestCalculator simpleInterest = new InterestCalculator(2500m, 0.072m, 8, InterestCalculatorMain.GetSimpleInterest);
        }

        [TestMethod]
        public void Test_GetSimpleInterestMethod()
        {
            // arrange
            decimal money = 2500m;
            decimal interest = 0.072m;
            int years = 15;
            decimal expected = 5200.0000m;
            InterestCalculator simpleInterest = new InterestCalculator(2500m, 0.072m, 15, InterestCalculatorMain.GetSimpleInterest);

            // assert
            decimal actual = simpleInterest.Balance;
            Assert.AreEqual(expected, actual, "Interest not calculated correctly");
        }

        [TestMethod]
        public void Test_GetCompoundInterestMethod()
        {
            // arrange
            decimal money = 500m;
            decimal interest = 0.056m;
            int years = 10;
            decimal expected = 874.1968m;
            InterestCalculator compoundInterest = new InterestCalculator(500m, 0.056m, 10, InterestCalculatorMain.GetCompoundInterest);

            // assert
            decimal actual = compoundInterest.Balance;
            Assert.AreEqual(expected, actual, "Interest not calculated correctly");
        }
    }
}
