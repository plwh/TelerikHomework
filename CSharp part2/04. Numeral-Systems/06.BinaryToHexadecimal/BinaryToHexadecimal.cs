// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter a binary number:");
        string input = Console.ReadLine();
        var result = new List<string>();
        int splitInputLength = input.Length % 4;
        if (splitInputLength > 0)
            result.Add(input.Substring(0, splitInputLength));
        for (int i = splitInputLength; i < input.Length; i += 4)
        {
            result.Add(input.Substring(i, 4));
        }
        Console.Write("Binary to hexadecimal:");
        foreach(string i in result)
        {
            switch(i) 
            {
                case "0000": Console.Write("0"); break;
                case "0001": Console.Write("1"); break;
                case "0010": Console.Write("2"); break;
                case "0011": Console.Write("3"); break;
                case "0100": Console.Write("4"); break;
                case "0101": Console.Write("5"); break;
                case "0110": Console.Write("6"); break;
                case "0111": Console.Write("7"); break;
                case "1000": Console.Write("8"); break;
                case "1001": Console.Write("9"); break;
                case "1010": Console.Write("A"); break;
                case "1011": Console.Write("B"); break;
                case "1100": Console.Write("C"); break;
                case "1101": Console.Write("D"); break;
                case "1110": Console.Write("E"); break;
                case "1111": Console.Write("F"); break;
            }
        }
        Console.WriteLine();
    }
}

