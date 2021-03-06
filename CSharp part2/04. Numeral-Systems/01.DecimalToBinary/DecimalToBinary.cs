﻿// Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter a decimal number:");
        long decimalNumber = long.Parse(Console.ReadLine());
        int length = int.MaxValue;
        string result = "";
        for (int i = 0; i < length; i++)
        {
            result = result + (decimalNumber % 2).ToString();
            decimalNumber = decimalNumber / 2;
            if (decimalNumber == 0)
            {
                break;
            }
        }
        char[] reversal = result.ToCharArray();
        Array.Reverse(reversal);
        result = new string(reversal);
        Console.WriteLine("Decimal to binary:{0}", result);
    }
}
