using System;

namespace MatrixCalculateLibrary
{
    public static class TriangularMatrixCalculator
    {
        /// <summary>
        /// Converts matrix to triangular form.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <param name="roundIndex">Number for matrix elements round</param>
        /// <param name="shouldSort">Should we sort elements on every iteration</param>
        /// <returns>Triangular matrix</returns>
        public static double[,] CalculateTriangularMatrix(double[,] matrix, int roundIndex, bool shouldSort)
        {
            int index = 0;
            int rowLength = matrix.GetLength(0);
            int columnLength = matrix.GetLength(1);

            while (index < columnLength - 1)
            {
                if (shouldSort && index < columnLength - 2)
                {
                    SortByRowMaxValue(matrix, index);
                }

                for (int i = rowLength - 2; i >= index; i--)
                {
                    double multiplier = matrix[i + 1, index] / matrix[i, index];

                    for (int j = index; j < columnLength; j++)
                    {
                        matrix[i + 1, j] -= multiplier * matrix[i, j];
                        matrix[i + 1, j] = Math.Round(matrix[i + 1, j], roundIndex);
                    }
                }

                index++;
            }

            return matrix;
        }

        /// <summary>
        /// Sorts matrix by row max value.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <param name="columnIndex">Column element which will compare</param>
        /// <returns>Returns sorted matrix</returns>
        public static double[,] SortByRowMaxValue(double[,] matrix, int columnIndex)
        {
            int length = matrix.GetLength(0);

            for (int i = 1; i < length; i++)
            {
                for (int j = columnIndex; j < length - i; j++)
                {
                    if (matrix[j, columnIndex] < matrix[j + 1, columnIndex])
                    {
                        SwapLines(matrix, j, j + 1);
                    }
                }
            }

            return matrix;
        }

        /// <summary>
        /// Swaps lines in matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <param name="first">Index of first row</param>
        /// <param name="second">Index of second row</param>
        /// <returns>Matrix with swaped lines</returns>
        public static double[,] SwapLines(double[,] matrix, int first, int second)
        {
            int length = matrix.GetLength(1);

            if (first > length - 1 || first < 0
                || second > length - 1 || second < 0)
            {
                throw new MatrixExeption(Constants.RowOutOfTheRangeException);
            }

            double[] temp = new double[length];

            for (int i = 0; i < length; i++)
            {
                temp[i] = matrix[second, i];
                matrix[second, i] = matrix[first, i];
                matrix[first, i] = temp[i];
            }

            return matrix;
        }
    }
}
