/*  Write a program that fills and prints a matrix of size (n, n) as shown below:
 *  Example for n=4:
      a)	              b)	              c)	               d)*
1	5	9	13      1   8   9   16      7	11	14	16       1	12	11	10
2	6	10  14      2   7   10  15      4	8	12	15       2	13	16	9
3	7	11	15      3   6   11  14      2	5	9	13       3	14	15	8
4	8	12	16      4   5   12  13      1	3	6	10       4	5	6	7        */

using System;

class FillTheMatrix
{
    public static void Print(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" " + matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter n:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrixA = new int[n, n];
        int value = 1;
        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            if (row > 0)
            {
                value = row + 1;
            }
            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                matrixA[row, col] = value;
                value = value + 4;
            }
        }
        Console.WriteLine("a)");
        Print(matrixA);
        int[,] matrixB = new int[n, n];
        for (int row = 0; row < matrixB.GetLength(0); row++)
        {    
            for (int col = 0; col < matrixB.GetLength(1); col++)
            {
                if ((col % 2) == 0)
                {
                    matrixB[row,col] = row + 1 + (n * col);
                }
                else
                {
                    matrixB[n - row - 1, col] = row + 1 + (n * col);
                }
            }
        }
        Console.WriteLine("b)");
        Print(matrixB);
        int[,] matrixC = new int[n, n];
        value = 1;
        int rows = 0;
        int cols = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrixC[rows++, cols++] = value++;
            }
        }
        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrixC[cols++,rows++] = value++;
            }
        }
        Console.WriteLine("c)");
        Print(matrixC);
    }
}

