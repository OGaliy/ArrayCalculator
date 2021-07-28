using Xunit;

namespace MatrixCalculateLibrary.Test
{
    public class MultiplyMatrixCalculatorTest
    {
        /// <summary>
        /// Checks matrix multiply.
        /// Test datas got from:
        /// https://www.mathsisfun.com/algebra/matrix-multiplying.html
        /// </summary>
        [Fact]
        public void Multiply_ShouldCalculate()
        {
            int[,] a = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[,] b = new int[3, 2]
            {
                { 7, 8 },
                { 9, 10 },
                { 11, 12 }
            };

            int[,] expected = new int[2, 2]
            {
                { 58, 64 },
                { 139, 154 }
            };

            int[,] actual = MultiplyMatrixCalculator.Multiply(a, b);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Checks throwing exeption when matrixies have different size.
        /// </summary>
        [Fact]
        public void Multiply_ShouldThrowException()
        {
            int[,] a = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[,] b = new int[2, 2]
            {
                { 7, 8 },
                { 9, 10 }
            };

            Assert.Throws<MatrixExeption>(() => MultiplyMatrixCalculator.Multiply(a, b));
        }

        /// <summary>
        /// Checks matrix multiply to number.
        /// Test datas got from:
        /// https://www.mathsisfun.com/algebra/matrix-multiplying.html
        /// </summary>
        [Fact]
        public void MultiplyToNumber_ShouldCalculate()
        {
            int[,] a = new int[2, 2]
            {
                { 4, 0 },
                { 1, -9 }
            };

            int b = 2;

            int[,] expected = new int[2, 2]
            {
                { 8, 0 },
                { 2, -18 }
            };

            int[,] actual = MultiplyMatrixCalculator.MultiplyToNumber(b, a);

            Assert.Equal(expected, actual);
        }
    }
}
