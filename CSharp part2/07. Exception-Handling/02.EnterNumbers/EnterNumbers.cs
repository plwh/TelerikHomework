// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class EnterNumbers
{
    static int ReadNumber(int start, int end, int prevNum)
    {
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number < prevNum)
            {
                throw new InvalidOperationException();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Number was not between {0} and {1}", start, end);
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Next number should be bigger than the previous one.Try again.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Input cannot be converted to int.Try again.");
        }
        return number;
    }
    static void Main()
    {
        int start = 1;
        int end = 100;
        Console.WriteLine("Enter 10 numbers\nEach number should be bigger than the previous one and in range [1 - 100]:");
        int number = 0;
        int prevNum = 0;
        for (int i = 0; i < 10; i++)
        {
            number = ReadNumber(start, end, prevNum);
            prevNum = number;
        }
    }
}

