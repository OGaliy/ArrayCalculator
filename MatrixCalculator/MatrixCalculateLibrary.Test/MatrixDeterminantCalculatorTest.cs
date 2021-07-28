using Xunit;

namespace MatrixCalculateLibrary.Test
{
    public class MatrixDeterminantCalculatorTest
    {
        /// <summary>
        /// Checks determinant calculating for matrix 4x4
        /// Test datas got from:
        /// https://www.assignmentexpert.com/blog/how-to-calculate-4x4-determinant/
        /// </summary>
        [Fact]
        public void CalculateDeterminant_ShouldCalculate4x4()
        {
            double[,] a = new double[4, 4]
            {
                { -1, 1, 4, 2 },
                { 2, -1, 2, 5 },
                { 1, 2, 3, 4 },
                { 3, 4, -1, 2 }
            };

            double expected = -26;

            double actual = MatrixDeterminantCalculator.CalculateDeterminant(0, a);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Checks determinant calculating for matrix 2x2
        /// Test datas got from:
        /// https://www.chilimath.com/lessons/advanced-algebra/determinant-2x2-matrix/
        /// </summary>
        [Fact]
        public void CalculateDeterminant_ShouldCalculate2x2()
        {
            double[,] a = new double[2, 2]
            {
                { 1, 2 },
                { 3, 4 }
            };

            double expected = -2;

            double actual = MatrixDeterminantCalculator.CalculateDeterminant(0, a);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Checks throwing exeption when matrix is not square.
        /// </summary>
        [Fact]
        public void CalculateDeterminant_ShouldThrowException()
        {
            double[,] a = new double[2, 3]
            {
                { 1, 2, 2 },
                { 3, 4, 4 }
            };

            Assert.Throws<MatrixExeption>(() => MatrixDeterminantCalculator.CalculateDeterminant(0, a));
        }
    }
}
