// Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a binary number:");
        string binaryNumber = Console.ReadLine();
        long a = long.Parse(binaryNumber);
        long sum = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            long lastDigit = a % 10;
            sum = sum + lastDigit * (long)(Math.Pow(2, i));
            a = a / 10;
        }
        Console.WriteLine("Binary to decimal:{0}", sum);
    }
}
