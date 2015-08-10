/* Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order. */

using System;

class SortingArray
{
    static void Print(int[]arr)
    {
        for (int i= 0; i < arr.Length;i++)
        {
            Console.Write(arr[i]+", ");
        }
        Console.WriteLine();
    }
    static void SortDescending(int[] arr)
    {
        int[] descendingSort = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            descendingSort[i] = MaximalElement(arr, i, arr.Length - 1, i);
        }
        Print(descendingSort);
    }
    static void SortAscending(int[] arr)
    {
        int[] ascendingSort = new int[arr.Length];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            ascendingSort[i] = MaximalElement(arr, 0, i, i);
        }
        Print(ascendingSort);
    }
    static int MaximalElement(int[] arr,int startIndex,int endIndex, int swapIndex=0)
    { 
        int maxIndex = startIndex;
        for (int i = startIndex; i <= endIndex; i++)
        {        
                if (arr[maxIndex] < arr[i])
                {
                    maxIndex = i;
                }
        }
        int temp = arr[swapIndex];
        arr[swapIndex] = arr[maxIndex];
        arr[maxIndex] = temp;
        return arr[swapIndex];
    }
    static void Main()
    {
            Console.WriteLine("We are given array with elements");
            int[] array = { 1, 17, 64, 32, 7, 14, 53, 20 };
            foreach (int number in array)
            {
                Console.Write(number + ", ");
            }
            Console.Write("\nEnter start index:");
            int startIndex = int.Parse(Console.ReadLine());
            Console.Write("Enter end index:");
            int endIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximal element in range [{0}...{1}]:{2}", startIndex,endIndex, MaximalElement(array,startIndex,endIndex));
            Console.WriteLine("Array sorted in ascending order:");
            SortAscending(array);
            Console.WriteLine("Array sorted in descending order:");
            SortDescending(array);
    }
}

