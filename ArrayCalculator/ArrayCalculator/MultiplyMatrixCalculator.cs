namespace MatrixCalculateLibrary
{
    public static class MultiplyMatrixCalculator
    {
        /// <summary>
        /// Multiplies double matrix to number.
        /// </summary>
        /// <param name="number">Number for multiply</param>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Result of multiply</returns>
        public static double[,] MultiplyToNumber(double number, double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] *= number;
                }
            }

            return matrix;
        }

        /// <summary>
        /// Multiplies int matrix to number.
        /// </summary>
        /// <param name="number">Number for multiply</param>
        /// <param name="matrix">Input matrix</param>
        /// <returns>Result of multiply</returns>
        public static int[,] MultiplyToNumber(int number, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] *= number;
                }
            }

            return matrix;
        }

        /// <summary>
        /// Multiplies two double matrix.
        /// For correct result count of columns matrix A
        /// should be same as count of rows matrix B.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Result of multiply</returns>
        public static double[,] Multiply(double[,] a, double[,] b)
        {
            var rows = a.GetLength(0);
            var columns = b.GetLength(1);

            if (a.GetLength(1) != b.GetLength(0))
            {
                throw new MatrixExeption(Constants.MultiplyException);
            }

            double[,] result = new double[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    double element = 0;
                    for (int i = 0; i < a.GetLength(1); i++)
                    {
                        element += a[r, i] * b[i, c];
                    }

                    result[r, c] = element;
                }
            }

            return result;
        }

        /// <summary>
        /// Multiplies two int matrix.
        /// For correct result count of columns matrix A
        /// should be same as count of rows matrix B.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Result of multiply</returns>
        public static int[,] Multiply(int[,] a, int[,] b)
        {
            var rows = a.GetLength(0);
            var columns = b.GetLength(1);

            int[,] result = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    int element = 0;
                    for (int i = 0; i < a.GetLength(1); i++)
                    {
                        element += a[r, i] * b[i, c];
                    }

                    result[r, c] = element;
                }
            }

            return result;
        }
    }
}
