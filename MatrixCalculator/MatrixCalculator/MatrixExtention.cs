using System;

namespace MatrixCalculateLibrary
{
    public static class MatrixExtention
    {
        /// <summary>
        /// Adds two double matrix.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Sum of matrix</returns>
        public static double[,] Add(this double[,] a, double[,] b)
        {
            return BasicMatrixArithmetic.Add(a, b);
        }

        /// <summary>
        /// Adds two int matrix.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Sum of matrix</returns>
        public static int[,] Add(this int[,] a, int[,] b)
        {
            return BasicMatrixArithmetic.Add(a, b);
        }

        /// <summary>
        /// Calculates determinant for double matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <param name="row">Input row</param>
        /// <returns>Determinant value</returns>
        public static double Determinant(this double[,] matrix, int row)
        {
            return MatrixDeterminantCalculator.CalculateDeterminant(row, matrix);
        }

        /// <summary>
        /// Calculates determinant for int matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <param name="row">Input row</param>
        /// <returns>Determinant value</returns>
        public static int Determinant(this int[,] matrix, int row)
        {
            return MatrixDeterminantCalculator.CalculateDeterminant(row, matrix);
        }

        /// <summary>
        /// Calculates cofactor matrix.
        /// </summary>
        /// <param name="rowIndex">Index of row element(starts from 0)</param>
        /// <param name="columnIndex">Index of column element(starts from 0)</param>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Cofactor matrix</returns>
        public static double[,] ElementCofactor(this double[,] matrix, int rowIndex, int columnIndex)
        {
            return MatrixCalculator.CalculateElementCofactor(rowIndex, columnIndex, matrix);
        }

        /// <summary>
        /// Calculates cofactor matrix.
        /// </summary>
        /// <param name="rowIndex">Index of row element(starts from 0)</param>
        /// <param name="columnIndex">Index of column element(starts from 0)</param>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Cofactor matrix</returns>
        public static int[,] ElementCofactor(this int[,] matrix, int rowIndex, int columnIndex)
        {
            return MatrixCalculator.CalculateElementCofactor(rowIndex, columnIndex, matrix);
        }

        /// <summary>
        /// Calculates invert matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Inverted matrix</returns>
        public static double[,] Invert(this double[,] matrix)
        {
            return InvertMatrixCalculator.CalculateInvertMatrix(matrix);
        }

        /// <summary>
        /// Calculates invert matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Inverted matrix</returns>
        public static double[,] Invert(this int[,] matrix)
        {
            return InvertMatrixCalculator.CalculateInvertMatrix(matrix);
        }

        /// <summary>
        /// Multiplies double matrix to matrix.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Secont matrix</param>
        /// <returns>Result of multiply</returns>
        public static double[,] Multiply(this double[,] a, double[,] b)
        {
            return MultiplyMatrixCalculator.Multiply(a, b);
        }

        /// <summary>
        /// Multiplies int matrix to matrix.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Secont matrix</param>
        /// <returns>Result of multiply</returns>
        public static int[,] Multiply(this int[,] a, int[,] b)
        {
            return MultiplyMatrixCalculator.Multiply(a, b);
        }

        /// <summary>
        /// Multiplies double matrix to number.
        /// </summary>
        /// <param name="number">Number for multiply</param>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Result of multiply</returns>
        public static double[,] MultiplyToNumber(this double[,] matrix, double number)
        {
            return MultiplyMatrixCalculator.MultiplyToNumber(number, matrix);
        }

        /// <summary>
        /// Multiplies int matrix to number.
        /// </summary>
        /// <param name="number">Number for multiply</param>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Result of multiply</returns>
        public static int[,] MultiplyToNumber(this int[,] matrix, int number)
        {
            return MultiplyMatrixCalculator.MultiplyToNumber(number, matrix);
        }

        public static double[,] Round(this double[,] matrix, int number)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round(matrix[i, j], number);
                }
            }

            return matrix;
        }

        /// <summary>
        /// Subtract two double matrix.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Difference of matrix</returns>
        public static double[,] Subtract(this double[,] a, double[,] b)
        {
            return BasicMatrixArithmetic.Subtract(a, b);
        }

        /// <summary>
        /// Subtract two int matrix.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Difference of matrix</returns>
        public static int[,] Subtract(this int[,] a, int[,] b)
        {
            return BasicMatrixArithmetic.Subtract(a, b);
        }

        /// <summary>
        /// Creates string view for input matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>String view</returns>
        public static string ToMatrixString(this double[,] matrix)
        {
            string result = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += $"{matrix[i, j]} \t";
                }

                result += "\n";
            }

            return result;
        }

        /// <summary>
        /// Creates string view for input matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>String view</returns>
        public static string ToMatrixString(this int[,] matrix)
        {
            string result = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += $"{matrix[i, j]} \t";
                }

                result += "\n";
            }

            return result;
        }

        /// <summary>
        /// Calculates transpose matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Transposed matrix</returns>
        public static double[,] TransposeMatrix(this double[,] matrix)
        {
            return MatrixCalculator.CalculateTransposeMatrix(matrix);
        }

        /// <summary>
        /// Calculates transpose matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Transposed matrix</returns>
        public static int[,] TransposeMatrix(this int[,] matrix)
        {
            return MatrixCalculator.CalculateTransposeMatrix(matrix);
        }
    }
}
