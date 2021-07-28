using System;

namespace MatrixCalculateLibrary
{
    public static class InvertMatrixCalculator
    {
        /// <summary>
        /// Calculates invert matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Inverted matrix</returns>
        public static double[,] CalculateInvertMatrix(double[,] matrix)
        {
            int length = matrix.GetLength(0);
            double[,] cofactorMatrix = new double[length, length];
            double[,] transposeMatrix = new double[length, length];
            double[,] result = new double[length, length];

            if (length != matrix.GetLength(1))
            {
                throw new MatrixExeption(Constants.NotSquareException);
            }

            var determinant = MatrixDeterminantCalculator.CalculateDeterminant(0, matrix);

            if (determinant == 0)
            {
                throw new MatrixExeption(Constants.ZeroDeterminantException);
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    var cofMat = MatrixCalculator.CalculateCofactorMatrix(i, j, matrix);

                    // Need it for correct coeficient
                    cofactorMatrix[i, j] = cofMat.GetLength(0) == 2
                            ? Math.Pow(-1, (i + j + 2)) * MatrixDeterminantCalculator.CalculateDeterminant(i, cofMat)
                            : MatrixDeterminantCalculator.CalculateDeterminant(i, cofMat);
                }
            }

            transposeMatrix = MatrixCalculator.CalculateTransposeMatrix(cofactorMatrix);

            result = MultiplyMatrixCalculator.MultiplyToNumber((1 / determinant), transposeMatrix);

            return result;
        }

        /// <summary>
        /// Calculates invert matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Inverted matrix</returns>
        public static double[,] CalculateInvertMatrix(int[,] matrix)
        {
            int length = matrix.GetLength(0);
            double[,] cofactorMatrix = new double[length, length];
            double[,] transposeMatrix = new double[length, length];
            double[,] result = new double[length, length];

            if (length != matrix.GetLength(1))
            {
                throw new MatrixExeption(Constants.NotSquareException);
            }

            var determinant = MatrixDeterminantCalculator.CalculateDeterminant(0, matrix);

            if (determinant == 0)
            {
                throw new MatrixExeption(Constants.ZeroDeterminantException);
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    var cofMat = MatrixCalculator.CalculateCofactorMatrix(i, j, matrix);

                    // Need it for correct coeficient
                    cofactorMatrix[i, j] = cofMat.GetLength(0) == 2
                            ? Math.Pow(-1, (i + j + 2)) * MatrixDeterminantCalculator.CalculateDeterminant(i, cofMat)
                            : MatrixDeterminantCalculator.CalculateDeterminant(i, cofMat);
                }
            }

            transposeMatrix = MatrixCalculator.CalculateTransposeMatrix(cofactorMatrix);

            result = MultiplyMatrixCalculator.MultiplyToNumber((1 / determinant), transposeMatrix);

            return result;
        }
    }
}
