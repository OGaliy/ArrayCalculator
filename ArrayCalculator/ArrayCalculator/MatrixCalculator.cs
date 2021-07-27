namespace ArrayCalculator
{
    public static class MatrixCalculator
    {
        /// <summary>
        /// Multiplies two double matrix.
        /// For correct result count of columns matrix A
        /// should be same as count of rows matrix B
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Result of multiply</returns>
        public static double[,] Multiply(double[,] a, double[,] b)
        {
            var rows = a.GetLength(0);
            var columns = b.GetLength(1);

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
        /// should be same as count of rows matrix B
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
