/* Write a method that adds two positive integer numbers represented as arrays of 
digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits. */

using System;
using System.Linq;

class NumberAsArray
{
    static string[] SumTwoNumbers(string numberOne, string numberTwo)
    {
        var a = numberOne.Select(ch => ch - '0').ToArray();
        var b = numberTwo.Select(ch => ch - '0').ToArray();
        Array.Reverse(a);
        Array.Reverse(b);
        string[] result = new string[Math.Max(a.Length,b.Length)];
        int leftPosition =0;
        for (int i = 0; i < result.Length; i++)
        { 
            int number = (i<a.Length? a[i]:0) + (i<b.Length?b[i]:0)+leftPosition;
                leftPosition = number/10;
                result [i] = (number%10).ToString();
        }
            return result;      
    }
    static void Main()
    {
        Console.Write("Enter first positive number:");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter second positive number:");
        string secondNumber = Console.ReadLine();
        Console.Write("Sum of numbers:");
        string[] result = SumTwoNumbers(firstNumber, secondNumber);
        for (int i=result.Length-1;i>=0;i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}

