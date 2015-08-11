//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOfFiveNumbers
{
    static void Main()
    {
       Console.Write("Enter five numbers(separated by a space):");
       string numbers = Console.ReadLine();    
       string[] splitNumbers = numbers.Split(' '); 
       double firstNumber = Convert.ToDouble(splitNumbers[0]);
       double secondNumber = Convert.ToDouble(splitNumbers[1]);
       double thirdNumber = Convert.ToDouble(splitNumbers[2]);
       double fourthNumber = Convert.ToDouble(splitNumbers[3]);
       double fifthNumber = Convert.ToDouble(splitNumbers[4]);
        double sum = firstNumber+secondNumber+thirdNumber+fourthNumber+fifthNumber;
       Console.WriteLine("Sum of numbers:" + sum);
    }
}
