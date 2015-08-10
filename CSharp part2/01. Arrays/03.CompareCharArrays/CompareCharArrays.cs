// Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter first array length:");
        int firstArrayLength = int.Parse(Console.ReadLine());
        char[] arr1 = new char[firstArrayLength];
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write("arr1[{0}]:", i);
            arr1[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Enter second array length:");
        int secondArrayLength = int.Parse(Console.ReadLine());
        char[] arr2 = new char[secondArrayLength];
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write("arr2[{0}]:", i);
            arr2[i] = char.Parse(Console.ReadLine());
        }
        if (arr1.SequenceEqual(arr2))
        {
            Console.WriteLine("The two arrays are equal.");
        }
        else
        {
            int minLength = Math.Min(arr1.Length, arr2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine("Second array comes earlier lexicographically.");
                        break;
                    }
                    else if(arr1[i] < arr2[i])
                    {
                        Console.WriteLine("First array comes earlier lexicographically.");
                        break;
                    }
                    else if(arr1[i]==arr2[i])
                    {
                        continue;
                    }
                }
            }
        }
    }
}

