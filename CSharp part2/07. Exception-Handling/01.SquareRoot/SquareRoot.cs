// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print Invalid number.
// In all cases finally print Good bye.
// Use try-catch-finally block.

using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter an integer number:");
            int input = int.Parse(Console.ReadLine());
            if (input < 0)
            {
                throw new FormatException();
            }
            double squareRoot = Math.Sqrt(input);
            Console.WriteLine("Square root:{0}", squareRoot);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

