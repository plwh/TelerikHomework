// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    public static int Binary_Search(int[] arr, int x)
    {
        int mid = 0, low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            mid = low + (high - low) / 2;
            if (x == arr[mid])
            {
                return mid;
            }
            else if (x < arr[mid])
                high = mid - 1;
            else
                low = mid + 1;
        }
        return -1;
    }
    static void Main()
    {
        int[] array = { 11, 9, 8, 6, 4};
        Array.Sort(array);
        foreach (int i in array)
        {
            Console.Write(i + ",");
        }
        Console.WriteLine();
        Console.Write("Enter an element from the array above:");
        int x = int.Parse(Console.ReadLine());
        bool found = Binary_Search(array, x) != -1;
        if (found)
        {
            Console.WriteLine("Element {0} is at position {1}.", x, Binary_Search(array, x));
        }
        else
        {
            Console.WriteLine("Element {0} was not found.", x);
        }
    }
}

