// Write a program that finds the maximal increasing sequence in an array.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter array elements(separated by a space):");
        string number = Console.ReadLine();
        string[] splitNumbers = number.Split(' ');
        int[] arr = new int[splitNumbers.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(splitNumbers[i]);
        }
        int maxstart = 0;
        int max = 1;
        int start = 0;
        for (int i = 1; i < arr.Length; i++) 
        {
            if (arr[i] > arr[i - 1]) 
            {
               if (i - start + 1 > max) 
               {
                   max = i - start + 1;
                   maxstart = start;
               }
            } 
            else 
            {
               start = i;
            }
        }
        for (int i = 0; i < max; i++)
        {
            Console.Write(arr[maxstart+i]+", ");
        }
        Console.WriteLine();
    }   
}


