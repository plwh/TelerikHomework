// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.

using System;

class SumIntegers
{
    static int CalcSumOfIntegers(string input)
    { 
        int sum = 0;
        string [] numbers = input.Split(' ');
        foreach(string number in numbers)
        {
            sum += int.Parse(number);
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Enter sequence of positive integers(separated by space):");
        string input = Console.ReadLine();
        Console.WriteLine("Sum:{0}",CalcSumOfIntegers(input));
    }
}

