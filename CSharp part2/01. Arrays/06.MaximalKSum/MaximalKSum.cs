/* Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum. */

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter K:");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(array);
        int sum = 0;
        for (int i = array.Length - 1; k > 0; i--, k--)
        {
            sum += array[i];
            Console.Write(" " + array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Maximal sum:" + sum);
    }
}

