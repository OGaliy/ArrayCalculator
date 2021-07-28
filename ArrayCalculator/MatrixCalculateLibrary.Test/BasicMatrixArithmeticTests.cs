using Xunit;

namespace MatrixCalculateLibrary.Test
{
    public class BasicMatrixArithmeticTests
    {
        /// <summary>
        /// Checks matrix sum for 3x3.
        /// Test datas got from:
        /// https://www.math-only-math.com/addition-of-matrices.html
        /// </summary>
        [Fact]
        public void Add_ShouldCalculate()
        {
            double[,] a = new double[3, 3]
            {
                { -1, 2, 3 },
                { 2, -3, 1 },
                { 3, 1, -2 }
            };

            double[,] b = new double[3, 3]
            {
                { 3, -1, 2 },
                { 1, 0, 3 },
                { 2, -1, 0 }
            };

            double[,] expected = new double[3, 3]
            {
                { 2, 1, 5 },
                { 3, -3, 4 },
                { 5, 0, -2 }
            };

            double[,] actual = BasicMatrixArithmetic.Add(a, b);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Checks throwing exeption when matrixies have different size.
        /// </summary>
        [Fact]
        public void Add_ShouldThrowExeption()
        {
            double[,] a = new double[3, 3]
            {
                { -1, 2, 3 },
                { 2, -3, 1 },
                { 3, 1, -2 }
            };

            double[,] b = new double[2, 3]
            {
                { 3, -1, 2 },
                { 1, 0, 3 }
            };

            Assert.Throws<MatrixExeption>(() => BasicMatrixArithmetic.Add(a, b));
        }

        /// <summary>
        /// Checks matrix subtract for 3x3.
        /// Test datas got from:
        /// https://www.mathstips.com/matrix-subtraction/
        /// </summary>
        [Fact]
        public void Subtract_MatrixShouldCalculate()
        {
            double[,] a = new double[3, 3]
            {
                { 5, 4, 3 },
                { 7, 8, 9 },
                { 3, 12, -5 }
            };

            double[,] b = new double[3, 3]
            {
                { 2, 3, 4 },
                { 4, -5, 6 },
                { 0, 7, 8 }
            };

            double[,] expected = new double[3, 3]
            {
                { 3, 1, -1 },
                { 3, 13, 3 },
                { 3, 5, -13 }
            };

            double[,] actual = BasicMatrixArithmetic.Subtract(a, b);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Checks throwing exeption when matrixies have different size.
        /// </summary>
        [Fact]
        public void Subtract_ShouldThrowExeption()
        {
            double[,] a = new double[3, 3]
            {
                { -1, 2, 3 },
                { 2, -3, 1 },
                { 3, 1, -2 }
            };

            double[,] b = new double[2, 3]
            {
                { 3, -1, 2 },
                { 1, 0, 3 }
            };

            Assert.Throws<MatrixExeption>(() => BasicMatrixArithmetic.Subtract(a, b));
        }
    }
}
