namespace ClassFractionTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _02.Fraction_Calculator;

    [TestClass]
    public class ClassFractionTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Interest_WhenDenominatorIsNegative_ShouldThrowDivideByZeroException()
        {
            Fraction fraction = new Fraction(1, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void Interest_WhenSumNumeratorIsTooSmallOrTooLarge_ShouldThrowArithmeticException()
        {
            Fraction fraction6 = new Fraction(long.MaxValue, 1);
            Console.WriteLine("{0} = {1}\n", fraction6.SimpleFractionToString(), fraction6);
            Fraction fraction7 = new Fraction(1, 1);
            Console.WriteLine("{0} = {1}\n", fraction7.SimpleFractionToString(), fraction7);
            Fraction tooLarge = fraction6 + fraction7; 
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void Interest_WhenSumDenominatorIsTooLarge_ShouldThrowArithmeticException()
        {
            Fraction fraction6 = new Fraction(1, 1);
            Console.WriteLine("{0} = {1}\n", fraction6.SimpleFractionToString(), fraction6);
            Fraction fraction7 = new Fraction(1, long.MaxValue);
            Console.WriteLine("{0} = {1}\n", fraction7.SimpleFractionToString(), fraction7);
            Fraction tooLarge = fraction6 + fraction7;
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void Interest_WhenMultiplicationDenominatorIsTooLarge_ShouldThrowArithmeticException()
        {
            Fraction fraction6 = new Fraction(1, 2);
            Console.WriteLine("{0} = {1}\n", fraction6.SimpleFractionToString(), fraction6);
            Fraction fraction7 = new Fraction(1, long.MaxValue);
            Console.WriteLine("{0} = {1}\n", fraction7.SimpleFractionToString(), fraction7);
            Fraction tooLarge = fraction6 * fraction7;
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void Interest_WhenMultiplicationNominatorIsTooLargeOrTooSmall_ShouldThrowArithmeticException()
        {
            Fraction fraction6 = new Fraction(2, 1);
            Console.WriteLine("{0} = {1}\n", fraction6.SimpleFractionToString(), fraction6);
            Fraction fraction7 = new Fraction(long.MaxValue, 1);
            Console.WriteLine("{0} = {1}\n", fraction7.SimpleFractionToString(), fraction7);
            Fraction tooLarge = fraction6 * fraction7;
        }

        [TestMethod]
        public void Fraction_WithAllArgumentsValid_ShouldPassTest()
        {
            Fraction fraction = new Fraction(0, -1);
        }

        [TestMethod]
        public void Test_SumOperatorMethod()
        {
            // arrange
            Fraction fraction1 = new Fraction(22, 8);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction expected = new Fraction(51, 4);

            // assert
            Fraction actual = fraction1 + fraction2;
            Assert.AreEqual(expected, actual, "Fractions sum not calculated correctly");
        }

        [TestMethod]
        public void Test_SubtractionOperatorMethod()
        {
            // arrange
            Fraction fraction1 = new Fraction(22, 8);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction expected = new Fraction(-29, 4);

            // assert
            Fraction actual = fraction1 - fraction2;
            Assert.AreEqual(expected, actual, "Fractions difference not calculated correctly");
        }

        [TestMethod]
        public void Test_MultiplicationOperatorMethod()
        {
            // arrange
            Fraction fraction1 = new Fraction(22, 8);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction expected = new Fraction(55, 2);

            // assert
            Fraction actual = fraction1 * fraction2;
            Assert.AreEqual(expected, actual, "Fractions product not calculated correctly");
        }

        [TestMethod]
        public void Test_DivisionOperatorMethod()
        {
            // arrange
            Fraction fraction1 = new Fraction(22, 8);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction expected = new Fraction(11, 40);

            // assert
            Fraction actual = fraction1 / fraction2;
            Assert.AreEqual(expected, actual, "Fractions quotent not calculated correctly");
        }
    }
}
