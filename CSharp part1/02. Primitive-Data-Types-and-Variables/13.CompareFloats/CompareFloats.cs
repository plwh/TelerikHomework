/* Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. */

using System;

class CompareFloats
{
    static void Main()
    {
        Console.WriteLine("Compare two floating point numbers. Please use ',' instead of '.'\n");
        Console.Write("Enter first floating point number:");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second floating point number:");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        decimal eps = 0.000001M;
        decimal difference = Math.Abs(firstNumber - secondNumber);
        bool isEqual=true;
        if (difference < eps)
        {
            isEqual = true;
        }
        else if (difference >= eps)
        {
            isEqual = false;
        }
        Console.Write("Are {0} and {1} equal? ",firstNumber,secondNumber);
        string equality = (isEqual) ? "Yes" : "No";
        Console.WriteLine(equality);
    }
}

