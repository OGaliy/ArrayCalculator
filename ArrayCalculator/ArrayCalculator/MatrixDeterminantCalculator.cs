using System;

namespace MatrixCalculateLibrary
{
    public static class MatrixDeterminantCalculator
    {
        /// <summary>
        /// Calculates determinant for double matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <param name="row">Input row</param>
        /// <returns>Determinant value</returns>
        public static double CalculateDeterminant(int row, double[,] matrix)
        {
            double result = 0;
            int length = matrix.GetLength(0);

            if (length != matrix.GetLength(1))
            {
                throw new MatrixExeption(Constants.NotSquareException);
            }

            if (length > 2)
            {
                for (int i = 0; i < length; i++)
                {
                    result += Math.Pow(-1, (i + row + 2)) * matrix[row, i] * CalculateDeterminant(row, MatrixCalculator.CalculateElementCofactor(row, i, matrix));
                }

                return result;
            }
            else if (length > 1)
            {
                return CalculateDeterminantFor2x2Matrix(matrix);
            }
            else
            {
                return matrix[0, 0];
            }
        }

        /// <summary>
        /// Calculates determinant for int matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <param name="row">Input row</param>
        /// <returns>Determinant value</returns>
        public static int CalculateDeterminant(int row, int[,] matrix)
        {
            int result = 0;
            int length = matrix.GetLength(0);

            if (length != matrix.GetLength(1))
            {
                throw new MatrixExeption(Constants.NotSquareException);
            }

            if (length > 2)
            {
                for (int i = 0; i < length; i++)
                {
                    result += (int)Math.Pow(-1, (i + row + 2)) * matrix[row, i] * CalculateDeterminant(row, MatrixCalculator.CalculateElementCofactor(row, i, matrix));
                }

                return result;
            }
            else if (length > 1)
            {
                return CalculateDeterminantFor2x2Matrix(matrix);
            }
            else
            {
                return matrix[0, 0];
            }
        }

        /// <summary>
        /// Calculates determinant for 2x2 double matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Determinant value</returns>
        private static double CalculateDeterminantFor2x2Matrix(double[,] matrix)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        /// <summary>
        /// Calculates determinant for 2x2 int matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Determinant value</returns>
        private static int CalculateDeterminantFor2x2Matrix(int[,] matrix)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
    }
}
