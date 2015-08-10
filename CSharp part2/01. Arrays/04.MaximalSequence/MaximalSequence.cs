// Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Linq;
using System.Collections.Generic;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter array elements(separated by a space):");
        string number = Console.ReadLine();
        string[] splitNumbers = number.Split(' ');
        int[] arr = new int[splitNumbers.Length];
        for(int i=0;i<arr.Length;i++)
        {
            arr[i] = int.Parse(splitNumbers[i]);
        }
        int currIndex = 0;
        int currLength = 0;
        int bestLength = 0;
        int bestElement = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == arr[currIndex])
            {
                currLength++;
            }
            else
            {
                currIndex = i;
                currLength = 1;
            }
            if (currLength > bestLength)
            {
                bestLength = currLength;
                bestElement = arr[i];
            }
        }
        for (int i = 0; i < bestLength; i++)
        {
            Console.Write("{0},", bestElement);
        }
        Console.WriteLine();
    }
}

