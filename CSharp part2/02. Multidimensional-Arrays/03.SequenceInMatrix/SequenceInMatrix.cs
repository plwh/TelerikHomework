﻿/* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located
on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 
  Example:
        matrix	            result		      matrix	  result
  ha	fifi	ho	hi                     s	qq	s 
  fo	 ha	    hi	xx    ha, ha, ha       pp	pp	s     s, s, s
  xxx	 ho	    ha	xx                     pp	qq	s             */

using System;

class SequenceInMatrix
{
    static void Main()
    {
        Console.Write("Enter number of rows(N):");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns(M):");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("matrix[{0},{1}]:", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }
        int currElement = 0;
        int bestElement = 0;
        string sequence = "";
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-1;col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currElement++;
                }
                else
                {
                    currElement = 1;
                }
                if (currElement > bestElement)
                {
                    bestElement = currElement;
                    sequence = matrix[row,col];
                
                }
            }
            currElement = 1;
        }
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                if (matrix[row, col] == matrix[row+1, col])
                {
                    currElement++;
                }
                else
                {
                    currElement = 1;
                }
                if (currElement > bestElement)
                {
                    bestElement = currElement;
                    sequence = matrix[row, col];

                }
            }
            currElement = 1;
        }
        for(int row=0,col=0; row < matrix.GetLength(0)-1 && col < matrix.GetLength(1)-1;row++,col++)
        {
                if (matrix[row, col] == matrix[row+1, col+1])
                {
                    currElement++;
                }
                else
                {
                    currElement = 1;
                }
                if (currElement > bestElement)
                {
                    bestElement = currElement;
                    sequence = matrix[row, col];
                }   
        }
        Console.WriteLine("Longest sequence of equal strings");
        for (int j = 0; j < bestElement; j++)
        {
            Console.Write(sequence + ",");
        }
        Console.WriteLine();
    }
}

