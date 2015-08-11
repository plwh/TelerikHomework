/* Write a program that enters from the console a positive integer n and prints all the numbers 
from 1 to n not divisible by 3 and 7, on a single line, separated by a space. */

using System;

class NumbersNotDivisibleBy3And7
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
            if (i%3 == 0 || i%7 == 0)
            {
                continue;
            }
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
}

