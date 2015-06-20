using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02.Interest_Calculator;

namespace ClassInterestCalculatorTests
{
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
    }
}
