/* Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() 
finds the largest number in the array which is ≤ K. */

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter N:");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i=0;i<array.Length;i++)
        {
            Console.Write("arr[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter K:");
        int K = int.Parse(Console.ReadLine());
        Array.Sort(array);
        int index = Array.BinarySearch(array,K);
        while (index < 0)
        {
            K--;
            index = Array.BinarySearch(array, K);
        }
        Console.WriteLine("Largest number less or equal to K is {0}. It has index = {1}.", K, index);
    }
}

