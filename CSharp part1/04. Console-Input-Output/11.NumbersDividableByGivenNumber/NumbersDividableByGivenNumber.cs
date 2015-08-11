/* Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
such that the reminder of the division by 5 is 0. */

using System;

class NumbersDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        int p = 0;
        if (firstNumber < 0 || secondNumber < 0)
        {
            Console.WriteLine("Numbers must be positive.");
            return;
        }
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                p++;
                Console.Write(" {0},", i);
            }
        }
        Console.WriteLine(" P = {0}",p);        
    }
}

