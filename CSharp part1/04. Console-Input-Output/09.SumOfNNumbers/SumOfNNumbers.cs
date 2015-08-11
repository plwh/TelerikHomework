//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i=0;i<number;i++)
        {
            double numbers =double.Parse(Console.ReadLine());
            sum += numbers;       
        }
        Console.WriteLine("Sum of {0} numbers:{1}",number,sum);
    }
}