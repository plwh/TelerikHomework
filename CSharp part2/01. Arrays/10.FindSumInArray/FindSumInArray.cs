// Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class FindSumInArray
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
        Console.Write("Enter sum S:");
        int sum = int.Parse(Console.ReadLine());
        int startIndex = 0;
        int endIndex = 0;
        int partialSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            startIndex = i;
            for (int j = startIndex; j <= arr.Length; j++)
            {
                if (partialSum < sum)
                {
                    partialSum += arr[j];
                }
                else if (partialSum == sum)
                {
                    startIndex = i;
                    endIndex = j;
                    break;
                }
                else
                {
                    partialSum = 0;
                    break;
                }
            }
            if (partialSum == sum)
            {
                break;
            }
            else 
            {
                partialSum = 0;
            }
        }
        for (int k = startIndex; k < endIndex; k++)
        {
            Console.Write(arr[k] + ", ");
        }
        Console.WriteLine();
    }
}


