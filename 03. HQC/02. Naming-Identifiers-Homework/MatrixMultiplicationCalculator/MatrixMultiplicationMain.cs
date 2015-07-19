// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MatrixMultiplicationMain.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   This class contains the application's Main method.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MatrixMultiplicationCalculator
{
    /// <summary>
    ///     This class contains the application's Main method.
    /// </summary>
    public class MatrixMultiplicationMain
    {
        /// <summary>
        ///     Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            var factorOneMatrix = new double[,]
            {
                {
                    1, 3
                }, 
                {
                    5, 7
                }
            };
            var factorTwoMatrix = new double[,]
            {
                {
                    4, 2
                }, 
                {
                    1, 5
                }
            };

            var productMatrix = Calculator.MultiplyMatrices(factorOneMatrix, factorTwoMatrix);

            ConsoleWriter.PrintMatrix(productMatrix);
        }
    }
}