// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeNumbers1ToN
{
    static void Main()
    {
        Console.Write("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Random r = new Random();
        for (int i = 0; i < numbers.Length;i++)
        {
            numbers[i] = i+1;
        }
        Console.Write("Numbers from 1 to n:");
        for (int j = 0; j < numbers.Length; j++)
        {
            Console.Write(" "+numbers[j]);
        }
        Console.WriteLine();
        for (int i = numbers.Length; i > 1; i--)
        {
            // Pick random element to swap.
            int j = r.Next(i); // 0 <= j <= i-1
            // Swap.
            int temp = numbers[j];
            numbers[j] = numbers[i - 1];
            numbers[i - 1] = temp;
        }
        Console.Write("Numbers from 1 to n randomized:");
        foreach(int i in numbers)
        {
            Console.Write(" " + i);
        }
        Console.WriteLine();        
    }
}

