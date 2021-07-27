namespace MatrixCalculateLibrary
{
    public static class MatrixExtention
    {
        public static double[,] Multiply(this double[,] a, double[,] b)
        {
            return MultiplyMatrixCalculator.Multiply(a, b);
        }
    }
}
