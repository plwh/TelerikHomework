// Write a program that sorts an array of strings using the Quick sort algorithm.

using System;

class QuickSort
{
    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;
            while (numbers[right] > pivot)
                right--;
            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }
    static public void SortQuick(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            if (pivot > 1)
                SortQuick(arr, left, pivot - 1);
            if (pivot + 1 < right)
                SortQuick(arr, pivot + 1, right);
        }
    }
    static void Main()
    {
        int[] array = { 20, 50, 60, 30, 70, 1, 5 };
        Console.Write("Before sort:");
        foreach (int number in array)
        {
            Console.Write(number + ",");
        }
        Console.WriteLine();
        SortQuick(array, 0, array.Length - 1);
        Console.Write("After applying quick sort algorithm:");
        foreach (int number in array)
        {
            Console.Write(number + ",");
        }
        Console.WriteLine();
    }
}

