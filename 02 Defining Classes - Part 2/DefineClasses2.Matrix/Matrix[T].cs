namespace DefineClasses2.Matrix
{
    using System;
    using System.Globalization;
    using System.Text;

    [Version(2, 11)]
    public class Matrix<T>
        where T : struct, IConvertible, IEquatable<T>
    {
        private int rowsCount;
        private int colsCount;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            matrix = new T[Rows, Cols];
        }
        public Matrix(T[,] elements)
        {
            this.matrix = elements;
            this.Rows = elements.GetLength(0);
            this.Cols = elements.GetLength(1);
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentOutOfRangeException("Matrices must have same number of rows and columns");
            }

            var summed = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int r = 0; r < firstMatrix.rowsCount; r++)
            {
                for (int c = 0; c < firstMatrix.colsCount; c++)
                {
                    summed[r, c] = (T)Convert.ChangeType((firstMatrix[r, c].ToDecimal(NumberFormatInfo.CurrentInfo) + secondMatrix[r, c].ToDecimal(NumberFormatInfo.CurrentInfo)), typeof(T));
                }
            }

            return summed;
        }
        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentOutOfRangeException("Matrices must have same number of rows and columns");
            }

            var summed = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int r = 0; r < firstMatrix.rowsCount; r++)
            {
                for (int c = 0; c < firstMatrix.colsCount; c++)
                {
                    summed[r, c] = (T)Convert.ChangeType((firstMatrix[r, c].ToDecimal(NumberFormatInfo.CurrentInfo) - secondMatrix[r, c].ToDecimal(NumberFormatInfo.CurrentInfo)), typeof(T));
                }
            }

            return summed;
        }
        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new ArgumentOutOfRangeException("Number of columns in First Matrix should be equal to Number of rows in Second Matrix!");
            }

            var multipliedMatrix = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);
            decimal tempSum = 0m;
            
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < secondMatrix.Cols; col++)
                {
                    for (int i = 0; i < firstMatrix.Rows; i++)
                    {
                        tempSum += (firstMatrix[row, i].ToDecimal(NumberFormatInfo.CurrentInfo) * secondMatrix[i, col].ToDecimal(NumberFormatInfo.CurrentInfo));
                    }

                    multipliedMatrix[row, col] = (T)Convert.ChangeType(tempSum, typeof(T));
                    tempSum = 0;
                }
            }

            return multipliedMatrix;
        }
        public static explicit operator bool(Matrix<T> matrix)
        {
            for (int r = 0; r < matrix.rowsCount; r++)
            {
                for (int c = 0; c < matrix.colsCount; c++)
                {
                    if (matrix[r, c].Equals(null) || matrix[r, c].Equals(0))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public int Rows
        {
            get { return this.rowsCount; }
            private set { this.rowsCount = value; }
        }
        public int Cols
        {
            get { return this.colsCount; }
            private set { this.colsCount = value; }
        }

        public T this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder matrixToString = new StringBuilder();

            for (int r = 0; r < this.rowsCount; r++)
            {
                for (int c = 0; c < this.colsCount; c++)
                {
                    matrixToString.Append(matrix[r, c].ToString());

                    if (c != this.colsCount - 1)
                    {
                        matrixToString.Append(' ');
                    }
                }

                if (r != this.rowsCount - 1)
                {
                    matrixToString.AppendLine();
                }
            }

            return matrixToString.ToString();
        }
    }
}