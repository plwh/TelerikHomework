//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {   
        Console.Write("Enter first array length:");
        int firstArrayLength = int.Parse(Console.ReadLine());
        int [] arr1 = new int[firstArrayLength];
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write("arr1[{0}]:", i);
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Enter second array length:");
        int secondArrayLength = int.Parse(Console.ReadLine());
        int[] arr2 = new int[secondArrayLength];
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write("arr2[{0}]:", i);
            arr2[i] = int.Parse(Console.ReadLine());
        }      
        Console.WriteLine("Two arrays are equal ? {0}", (arr1.SequenceEqual(arr2)));
    }
}

