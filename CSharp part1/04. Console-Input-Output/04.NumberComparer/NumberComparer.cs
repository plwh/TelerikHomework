/* Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements. */

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("First number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is {0}",(firstNumber>secondNumber)?firstNumber:secondNumber);
    }
}

