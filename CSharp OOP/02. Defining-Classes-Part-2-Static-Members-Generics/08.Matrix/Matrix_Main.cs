using System;

namespace _08.Matrix
{
    class Matrix_Main
    {
        static void Main()
        {
            Matrix<int> firstMatrix = new Matrix<int>(2,2);
            Matrix<int> secondMatrix = new Matrix<int>(2, 2);

            for (int i = 0; i < firstMatrix.Rows;i++)
            {
                for (int j = 0; j < firstMatrix.Columns; j++)
                {
                    firstMatrix[i, j] = i+2;
                    secondMatrix[i, j] = i+3;
                }
            }

            Console.WriteLine("First matrix elements:\n{0}",firstMatrix);
            Console.WriteLine("Second matrix elements:\n{0}",secondMatrix);
            Console.WriteLine("First matrix + second matrix:\n{0}", firstMatrix + secondMatrix);
            Console.WriteLine("First matrix - second matrix:\n{0}", firstMatrix - secondMatrix);
            Console.WriteLine("First matrix * second matrix:\n{0}", firstMatrix * secondMatrix);
            bool containsZero = (firstMatrix) ? false: true;
            Console.WriteLine("First matrix contains zeroes? " + containsZero);
        }
    }
}
