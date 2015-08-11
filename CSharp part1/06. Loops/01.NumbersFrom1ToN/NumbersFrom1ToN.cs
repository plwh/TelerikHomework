/* Write a program that enters from the console a positive integer n and prints 
all the numbers from 1 to n, on a single line, separated by a space. */

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter an integer number:");
        int number = int.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("The number must be positive");
            return;
        }
        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

