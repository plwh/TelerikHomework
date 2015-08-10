// Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter array length:");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}]:", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int currentSum = arr[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempStartIndex = 0;
        int maxSum = arr[0];
        for (int i = 1; i < arr.Length;i++)
        {
            if (currentSum < 0)
            {
                currentSum = arr[i];
                tempStartIndex = i;
            }
            else
            {
                currentSum += arr[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = tempStartIndex;
                endIndex = i;
            }
        }
        Console.Write("Sequence of maximal sum:");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(arr[i]+", ");
        }
        Console.WriteLine();
    }
}

