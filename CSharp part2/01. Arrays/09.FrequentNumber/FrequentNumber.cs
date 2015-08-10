// Write a program that finds the most frequent number in an array.

using System;
using System.Collections.Generic;

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter array elements(separated by a space):");
        string number = Console.ReadLine();
        string[] splitNumbers = number.Split(' ');
        int[] arr = new int[splitNumbers.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(splitNumbers[i]);
        }
        Array.Sort(arr);
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
        Console.WriteLine("{0}({1} times)",bestElement,bestLength);
    }
}

