using System;

namespace MatrixCalculateLibrary
{
    public class MatrixExeption : Exception
    {
        public MatrixExeption()
        {
        }

        public MatrixExeption(string message) : base(message)
        {
        }

        public MatrixExeption(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
