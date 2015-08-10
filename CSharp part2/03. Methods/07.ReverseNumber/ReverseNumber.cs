// Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static string ReverseDigits(string number)
    {
        char[] numberReversal = new char[number.Length];
        string reversedNumber = "";
        foreach (char element in number)
        {
            reversedNumber = element + reversedNumber;
        }
        return reversedNumber;
    }
    static void Main()
    {
        Console.Write("Enter a number:");
        string number = Console.ReadLine();
        Console.WriteLine("Digits reversed:{0}", ReverseDigits(number));
    }
}

