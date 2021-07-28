namespace MatrixCalculateLibrary
{
    public static class BasicMatrixArithmetic
    {
        /// <summary>
        /// Adds two double matrix.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Sum of matrix</returns>
        public static double[,] Add(double[,] a, double[,] b)
        {
            if(a.GetLength(0) != b.GetLength(0) ||
                a.GetLength(1) != b.GetLength(1))
            {
                throw new MatrixExeption(Constants.WrongSizeException);
            }
            int rows = a.GetLength(0);
            int columns = a.GetLength(1);
            double[,] result = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }

        /// <summary>
        /// Adds two int matrix.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Sum of matrix</returns>
        public static int[,] Add(int[,] a, int[,] b)
        {
            if (a.GetLength(0) != b.GetLength(0) ||
                a.GetLength(1) != b.GetLength(1))
            {
                throw new MatrixExeption(Constants.WrongSizeException);
            }
            int rows = a.GetLength(0);
            int columns = a.GetLength(1);
            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }

        /// <summary>
        /// Subtract two double matrix.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Difference of matrix</returns>
        public static double[,] Subtract(double[,] a, double[,] b)
        {
            if (a.GetLength(0) != b.GetLength(0) ||
                a.GetLength(1) != b.GetLength(1))
            {
                throw new MatrixExeption(Constants.WrongSizeException);
            }
            int rows = a.GetLength(0);
            int columns = a.GetLength(1);
            double[,] result = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }

            return result;
        }        

        /// <summary>
        /// Subtract two int matrix.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>Difference of matrix</returns>
        public static int[,] Subtract(int[,] a, int[,] b)
        {
            if (a.GetLength(0) != b.GetLength(0) ||
                a.GetLength(1) != b.GetLength(1))
            {
                throw new MatrixExeption(Constants.WrongSizeException);
            }
            int rows = a.GetLength(0);
            int columns = a.GetLength(1);
            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }

            return result;
        }
    }
}
