//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        double thirdNumber = double.Parse(Console.ReadLine());
        double sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("Sum of numbers:" + sum);       
    }     
}

