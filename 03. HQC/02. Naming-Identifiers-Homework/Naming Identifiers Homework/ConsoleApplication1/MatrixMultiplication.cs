namespace ConsoleApplication1
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    class MatrixMultiplication
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        static void Main()
        {
            var factorOneMatrix = new double[,] { { 1, 3 }, { 5, 7 } };
            var factorTwoMatrix = new double[,] { { 4, 2 }, { 1, 5 } };

            var productMatrix = MultiplyMatrices(factorOneMatrix, factorTwoMatrix);
            
            for (int i = 0; i < productMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < productMatrix.GetLength(1); j++)
                {
                    Console.Write(productMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Multiplies the matrices.
        /// </summary>
        /// <param name="factorOneMatrix">The factor one matrix.</param>
        /// <param name="factorTwoMatrix">The factor two matrix.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">The columns number of the first matrix must be equal to the rows number of the second matrix.</exception>
        static double[,] MultiplyMatrices(double[,] factorOneMatrix, double[,] factorTwoMatrix)
        {
            if (factorOneMatrix.GetLength(1) != factorTwoMatrix.GetLength(0))
            {
                throw new ArgumentException("The columns number of the first matrix must be equal to the rows number of the second matrix.");
            }

            var firstMatrixCols = factorOneMatrix.GetLength(1);
            var resultMatrix = new double[factorOneMatrix.GetLength(0), factorTwoMatrix.GetLength(1)];

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < firstMatrixCols; k++)
                    {
                        resultMatrix[i, j] += factorOneMatrix[i, k] * factorTwoMatrix[k, j];
                    }
                }
            }
                
            return resultMatrix;
        }
    }
}