// Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Numerics;

class NFactorial
{
    static BigInteger CalculateNFactorial(int number)
    { 
        BigInteger product = 1;
        for (int i = number; i > 0 ; i--)
        {
            product *= i;
        }
        return product;    
    }
    static void Main()
    {
        Console.WriteLine("n! for each n in the range [1..100]");
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(CalculateNFactorial(i));
        }
    }
}

