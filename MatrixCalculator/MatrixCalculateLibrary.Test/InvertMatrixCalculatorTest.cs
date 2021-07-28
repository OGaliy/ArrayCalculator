using Xunit;

namespace MatrixCalculateLibrary.Test
{
    public class InvertMatrixCalculatorTest
    {
        /// <summary>
        /// Checks inverting 3x3 matrix.
        /// Test datas got from:
        /// https://www.mathsisfun.com/algebra/matrix-inverse-minors-cofactors-adjugate.html
        /// </summary>
        [Fact]
        public void CalculateInvertMatrix_ShouldCalculate()
        {
            double[,] a = new double[3, 3]
            {
                { 3, 0, 2 },
                { 2, 0, -2 },
                { 0, 1, 1 }
            };

            double[,] expected = new double[3, 3]
            {
                { 0.2, 0.2, 0 },
                { -0.2, 0.3, 1 },
                { 0.2, -0.3, 0 }
            };

            double[,] actural = InvertMatrixCalculator.CalculateInvertMatrix(a);

            Assert.Equal(expected, actural);
        }

        /// <summary>
        /// Checks throwing exception when determinant equal 0.
        /// </summary>
        [Fact]
        public void CalculateInvertMatrix_ShouldThrowException()
        {
            double[,] a = new double[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Assert.Throws<MatrixExeption>(() => InvertMatrixCalculator.CalculateInvertMatrix(a));
        }
    }
}
