// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calculator.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The MatrixMultiplicationCalculator class contains a MultiplyMatrices method, which takes as arguments two double[,]
//   matrices
//   and returns a new product matrix.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MatrixMultiplicationCalculator
{
    using System;

    /// <summary>
    ///     The MatrixMultiplicationCalculator class contains a MultiplyMatrices method, which takes as arguments two double[,]
    ///     matrices
    ///     and returns a new product matrix.
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Multiplies the two matrices received as arguments.
        /// </summary>
        /// <param name="factorOneMatrix">
        /// The factor one matrix.
        /// </param>
        /// <param name="factorTwoMatrix">
        /// The factor two matrix.
        /// </param>
        /// <returns>
        /// a matrix which is the product of the multiplication of the two matrices received as arguments
        /// </returns>
        /// <exception cref="System.ArgumentException">
        /// The columns number of the first matrix must be equal to the rows number of
        ///     the second matrix.
        /// </exception>
        public static double[,] MultiplyMatrices(double[,] factorOneMatrix, double[,] factorTwoMatrix)
        {
            if (factorOneMatrix.GetLength(1) != factorTwoMatrix.GetLength(0))
            {
                throw new ArgumentException(
                    "The columns number of the first matrix must be equal to the rows number of the second matrix.");
            }

            var firstMatrixCols = factorOneMatrix.GetLength(1);
            var resultMatrix = new double[factorOneMatrix.GetLength(0), factorTwoMatrix.GetLength(1)];

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < firstMatrixCols; k++)
                    {
                        resultMatrix[i, j] += factorOneMatrix[i, k]*factorTwoMatrix[k, j];
                    }
                }
            }

            return resultMatrix;
        }
    }
}