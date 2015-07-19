// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleWriter.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The ConsoleWriter class contains a single static PrintMatrix method, accepting as argument a double[,] matrix.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MatrixMultiplicationCalculator
{
    using System;

    /// <summary>
    ///     The ConsoleWriter class contains a single static PrintMatrix method, accepting as argument a double[,] matrix.
    /// </summary>
    public static class ConsoleWriter
    {
        /// <summary>
        /// Prints the matrix.
        /// </summary>
        /// <param name="matrix">
        /// The matrix.
        /// </param>
        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}