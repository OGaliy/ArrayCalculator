namespace ArrayCalculator
{
    public static class MatrixCalculator
    {
        public static decimal GetDeterminant(decimal[,] matrix)
        {

            return 0;
        }

        /// <summary>
        /// Multiplies two decimal matrix.
        /// For correct result count of columns matrix A
        /// should be same as count of rows matrix B
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Result of multiply</returns>
        public static decimal[,] Multiply(decimal[,] a, decimal[,] b)
        {
            var rows = a.GetLength(0);
            var columns = b.GetLength(1);

            decimal[,] result = new decimal[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    decimal element = 0;
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
