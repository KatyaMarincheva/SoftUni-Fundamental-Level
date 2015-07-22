// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Formatting.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The formatting.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Methods.Method_Classes
{
    using System;

    /// <summary>
    /// The formatting.
    /// </summary>
    public static class Formatting
    {
        /// <summary>
        /// Prints a digit as word.
        /// </summary>
        /// <param name="digit">
        /// The input digit.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string PrintDigitAsWord(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
            }

            return "Not a digit!";
        }

        /// <summary>
        /// Formats a number according to the provided input string.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="format">The format string.</param>
        /// <returns>formatted string</returns>
        /// <exception cref="System.ArgumentException">Wrong format string!;format</exception>
        public static string FormatNumber(object number, string format)
        {
            string formatString = format.ToLower();
            switch (formatString)
            {
                case "f":
                    return string.Format("{0:f2}", number);
                case "%":
                    return string.Format("{0:p0}", number);
                case "r":
                    return string.Format("{0,8}", number);
            }

            throw new ArgumentException("Wrong format string!", "format");
        }
    }
}