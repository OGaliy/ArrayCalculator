using Xunit;

namespace MatrixCalculateLibrary.Test
{
    public class TriangularMatrixCalculatorTests
    {
        /// <summary>
        /// Tests calculating triangular matrix.
        /// </summary>
        [Fact]
        public void CalculateTriangularMatrix_ShouldCalculate()
        {
            double[,] a = new double[4, 4]
            {
                { 1, 3, 2, -1 },
                { 2, 4, 0, 1 },
                { -1, 3, 2, -4 },
                { 3, 3, -2, 5 }
            };

            double[,] expected = new double[4, 4]
            {
                { 1, 3, 2, -1 },
                { 0, -2, -4, 3 },
                { 0, 0, -8, 4 },
                { 0, 0, 0, 1 }
            };

            var actual = TriangularMatrixCalculator.CalculateTriangularMatrix(a, 1, false);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Tests swaping lines.
        /// </summary>
        [Fact]
        public void SwapLines_ShouldSwap()
        {
            double[,] a = new double[4, 4]
            {
                { 1, 3, 2, -1 },
                { 2, 4, 0, 1 },
                { -1, 3, 2, -4 },
                { 3, 3, -2, 5 }
            };

            double[,] expected = new double[4, 4]
            {
                { 1, 3, 2, -1 },
                { 2, 4, 0, 1 },
                { 3, 3, -2, 5 },
                { -1, 3, 2, -4 }
            };

            var actual = TriangularMatrixCalculator.SwapLines(a, 2, 3);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Tests throwing exeption when lines for swap are not correct.
        /// </summary>
        [Fact]
        public void SwapLines_ShouldThrowException()
        {
            double[,] a = new double[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Assert.Throws<MatrixExeption>(() => TriangularMatrixCalculator.SwapLines(a, 1, 4));
        }

        /// <summary>
        /// Tests sorting matrix by row max vallue.
        /// </summary>
        [Fact]
        public void SortByRowMaxValue_ShouldSort()
        {
            double[,] a = new double[4, 4]
            {
                { 1, 3, 2, -1 },
                { 2, 4, 0, 1 },
                { -1, 3, 2, -4 },
                { 3, 3, -2, 5 }
            };

            double[,] expected = new double[4, 4]
            {
                { 3, 3, -2, 5 },
                { 2, 4, 0, 1 },
                { 1, 3, 2, -1 },
                { -1, 3, 2, -4 }
            };

            var actual = TriangularMatrixCalculator.SortByRowMaxValue(a, 0);

            Assert.Equal(expected, actual);
        }
    }
}
