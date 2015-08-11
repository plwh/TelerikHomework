/* Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix 
like in the examples below. Use two nested loops.

n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7 */

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        int value = 1;
        int [,] matrix = new int[n,n];
        if (n > 1 && n < 20)
        {
            for (int row = 0; row < n; row++)
            {
                if (row > 0)
                {
                    value = row + 1;
                }
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = value;
                    value += 1;
                    
                }              
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }              
            Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Number must be in range (1 < n < 20)");
            return;
        }
    }
}

