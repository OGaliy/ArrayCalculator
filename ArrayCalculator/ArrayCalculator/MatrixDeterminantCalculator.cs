using System;

namespace MatrixCalculator
{
    public static class MatrixDeterminantCalculator
    {
        /// <summary>
        /// Calculates determinant for double matrix
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Determinant value</returns>
        public static double CalculateDeterminant(double[,] matrix)
        {
            double result = 0;
            int length = matrix.GetLength(0);

            if (length != matrix.GetLength(1))
            {
                throw new Exception("Not square matrix");
            }

            if (length > 2)
            {
                for (int i = 0; i < length; i++)
                {
                    result += Math.Pow(-1, (i + 2)) * matrix[0, i] * CalculateDeterminant(CalculateCofactorMatrix(0, i, matrix));
                }

                return result;
            }
            else if (length > 2)
            {
                return CalculateDeterminantFor2x2Matrix(matrix);
            }
            else
            {
                return matrix[0, 0];
            }
        }

        /// <summary>
        /// Calculates cofactor matrix.
        /// </summary>
        /// <param name="rowIndex">Index of row element(starts from 0)</param>
        /// <param name="columnIndex">Index of column element(starts from 0)</param>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Cofactor matrix</returns>
        public static double[,] CalculateCofactorMatrix(int rowIndex, int columnIndex, double[,] matrix)
        {
            int r = 0;
            int length = matrix.GetLength(0);

            if (length != matrix.GetLength(1))
            {
                throw new Exception("Not square matrix");
            }

            double[,] result = new double[length - 1, length - 1];

            for (int i = 0; i < length; i++)
            {
                int c = 0;

                for (int j = 0; j < length; j++)
                {
                    if (i != rowIndex && j != columnIndex)
                    {
                        result[r, c] = matrix[i, j];
                        c++;
                    }
                }
                r++;
            }

            return result;
        }

        /// <summary>
        /// Calculates determinant for 2x2 double matrix
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Determinant value</returns>
        private static double CalculateDeterminantFor2x2Matrix(double[,] matrix)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
    }
}
