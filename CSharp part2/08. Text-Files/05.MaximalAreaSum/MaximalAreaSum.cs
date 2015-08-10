// Write a program that reads a text file containing a square matrix of numbers.
// Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
// The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.
// The output should be a single number in a separate text file.

using System;
using System.IO;
using System.Text.RegularExpressions;

class MaximalAreaSum
{
    static void Main()
    {
        Console.WriteLine("We are given file \"matrix.txt\"(located in the main folder of this project)");
        StreamReader reader = new StreamReader("../../matrix.txt");
        StreamWriter writer = new StreamWriter("result.txt");
        string firstLine = reader.ReadLine();
        int size = int.Parse(firstLine);
        int[,] matrix = new int[size, size];
        int bestSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int col = 0;
            string elementLine = reader.ReadLine();
            string [] elements = Regex.Split(elementLine," ");
            foreach (string element in elements)
            {               
                matrix[row, col] = int.Parse(element);
                col++;
            }           
        }
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                    bestSum = sum;
            }
        }
        using (writer)
        {
            Console.WriteLine(@"The maximal sum of elements in 2x2 area in the matrix has been calculated.
Output file (result.txt) can be found in the bin\Debug folder of this project.");
            writer.WriteLine(bestSum);
        }     
    }
}

