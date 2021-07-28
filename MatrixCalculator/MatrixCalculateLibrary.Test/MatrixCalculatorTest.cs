using Xunit;

namespace MatrixCalculateLibrary.Test
{
    public class MatrixCalculatorTest
    {
        /// <summary>
        /// Checks calculating of cofactor elements.
        /// </summary>
        [Fact]
        public void CalculateElementCofactor_ShouldCalculate()
        {
            int[,] a = new int[3, 3]
            {
                { 1, 2, 3 },
                { 0, 4, 5 },
                { 1, 0, 6 }
            };

            int[,] expecter00 = new int[2, 2]
            {
                { 4, 5 },
                { 0, 6 }
            };

            int[,] expecter12 = new int[2, 2]
            {
                { 1, 2 },
                { 1, 0 }
            };

            int[,] actual00 = MatrixCalculator.CalculateElementCofactor(0, 0, a);
            int[,] actual12 = MatrixCalculator.CalculateElementCofactor(1, 2, a);

            Assert.Equal(expecter00, actual00);
            Assert.Equal(expecter12, actual12);
        }

        /// <summary>
        /// Checks throwing exception during calculating cofactor elements.
        /// </summary>
        [Fact]
        public void CalculateElementCofactor_ShouldThrowException()
        {
            int[,] a = new int[2, 3]
            {
                { 1, 2, 3 },
                { 0, 4, 5 },
            };

            Assert.Throws<MatrixExeption>(() => MatrixCalculator.CalculateElementCofactor(1, 1, a));
        }

        /// <summary>
        /// Checks calculating of transpose matrix.
        /// Test datas got from:
        /// https://mathinsight.org/matrix_transpose
        /// </summary>
        [Fact]
        public void CalculateTransposeMatrix_ShouldCalculate()
        {
            int[,] a = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[,] expected = new int[3, 2]
            {
                { 1, 4 },
                { 2, 5 },
                { 3, 6 }
            };

            int[,] actual = MatrixCalculator.CalculateTransposeMatrix(a);

            Assert.Equal(expected, actual);
        }
    }
}
