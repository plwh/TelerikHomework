// Problem 8: Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
// Problem 9: Implement an indexer this[row, col] to access the inner matrix cells.
// Problem 10: Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
//             Throw an exception when the operation cannot be performed.
//             Implement the true operator (check for non-zero elements).

using System;
using System.Text;

namespace _08.Matrix
{
    class Matrix<T> where T : IComparable
    {
        private T [,] matrix;

        public Matrix(int row, int col)
        {
            matrix = new T [row, col];
        }

        public int Rows
        {
            get { return this.matrix.GetLength(0); }
        }

        public int Columns
        {
            get { return this.matrix.GetLength(1); }
        }

        public T this[int row, int column]
        {
            get 
            {
                return matrix[row, column];         
            }
            set 
            {
                matrix[row, column] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Columns != secondMatrix.Columns)
            {
                throw new ArgumentException("Matrices don't have the same dimensions");               
            }
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);
            for (int i = 0; i < newMatrix.Rows; i++)
            {
                for (int j = 0; j < newMatrix.Columns; j++)
                {
                    newMatrix[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Columns != secondMatrix.Columns)
            {
                 throw new ArgumentException("Matrices don't have the same dimensions");
            }
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows,firstMatrix.Columns);
            for (int i = 0; i < newMatrix.Rows; i++)
            { 
                for(int j = 0; j< newMatrix.Columns; j++)
                {
                    newMatrix[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Columns != secondMatrix.Columns)
            {
               throw new ArgumentException("Matrices don't have the same dimensions");
            }
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);
            for (int i = 0; i < newMatrix.Rows; i++)
            {
                for (int j = 0; j < newMatrix.Columns; j++)
                {
                    newMatrix[i, j] = (dynamic)firstMatrix[i, j] * (dynamic)secondMatrix[i, j];
                }
            }
            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool result = true;
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool result = true;
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for(int j = 0; j < this.Columns; j++)
                {
                    output.Append(this.matrix[i,j]+" ");
                }
                output.Append("\n");
            }
            return output.ToString();
        }
    }
}
