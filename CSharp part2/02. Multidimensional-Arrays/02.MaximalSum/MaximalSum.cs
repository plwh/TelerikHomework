// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
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
        Console.Write("Enter number of rows(N):");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns(M):");
        int columns = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("matrix[{0},{1}]:", i, j);
                matrix[i,j]=int.Parse(Console.ReadLine());           
            }
        }
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0; 
        for(int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum =  matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                         + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                         + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("\nMatrix printed\n");
        Print(matrix); 
        Console.WriteLine("The best 3x3 platform is:");
        Console.WriteLine(" {0} {1} {2}",
                matrix[bestRow, bestCol],
                matrix[bestRow, bestCol + 1],
                matrix[bestRow, bestCol + 2]);
        Console.WriteLine(" {0} {1} {2}",
                matrix[bestRow+1, bestCol],
                matrix[bestRow+1, bestCol + 1],
                matrix[bestRow+1, bestCol + 2]);
        Console.WriteLine(" {0} {1} {2}",
                matrix[bestRow+2, bestCol],
                matrix[bestRow+2, bestCol + 1],
                matrix[bestRow+2, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);               
    }
}

