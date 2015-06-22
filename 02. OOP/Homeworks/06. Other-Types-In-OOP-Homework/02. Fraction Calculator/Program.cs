namespace _02.Fraction_Calculator
{
    using System;

    internal class Program
    {
        internal static void Main()
        {
            // Normalized => numerator and denominator divided by 2 (the GCD of 22 and 8)
            Fraction fraction1 = new Fraction(22, 8);

            // Normalized => numerator and denominator divided by 4 (the GCD of 40 and 4)
            Fraction fraction2 = new Fraction(40, 4);
            Fraction resultSum = fraction1 + fraction2;

            Console.WriteLine(
                "{0} + {1} = {2} = {3}\n", 
                fraction1.SimpleFractionToString(), 
                fraction2.SimpleFractionToString(), 
                resultSum.SimpleFractionToString(), 
                resultSum);

            Fraction resultSubtraction = fraction1 - fraction2;
            Console.WriteLine(
                "{0} - {1} = {2} = {3}\n",
                fraction1.SimpleFractionToString(),
                fraction2.SimpleFractionToString(),
                resultSubtraction.SimpleFractionToString(),
                resultSubtraction);

            Fraction resultMultiplication = fraction1 * fraction2;
            Console.WriteLine(
                "{0} * {1} = {2} = {3}\n",
                fraction1.SimpleFractionToString(),
                fraction2.SimpleFractionToString(),
                resultMultiplication.SimpleFractionToString(),
                resultMultiplication);

            Fraction resultDivision = fraction1 / fraction2;
            Console.WriteLine(
                "{0} / {1} = {2} = {3}\n",
                fraction1.SimpleFractionToString(),
                fraction2.SimpleFractionToString(),
                resultDivision.SimpleFractionToString(),
                resultDivision);

            Fraction fraction3 = new Fraction(0, -1);
            Console.WriteLine("{0} = {1}\n", fraction3.SimpleFractionToString(), fraction3);

            Fraction fraction4 = new Fraction(5, -3);
            Console.WriteLine("{0} = {1}\n", fraction4.SimpleFractionToString(), fraction4);

            Fraction fraction5 = new Fraction(10, 5); // Will be normalized to 2/1
            Console.WriteLine("{0} = {1}\n", fraction5.SimpleFractionToString(), fraction5);

            Fraction fraction6 = new Fraction(long.MaxValue, 1);
            Console.WriteLine("{0} = {1}\n", fraction6.SimpleFractionToString(), fraction6);

            Fraction fraction7 = new Fraction(1, 1);
            Console.WriteLine("{0} = {1}\n", fraction7.SimpleFractionToString(), fraction7);
        }
    }
}
