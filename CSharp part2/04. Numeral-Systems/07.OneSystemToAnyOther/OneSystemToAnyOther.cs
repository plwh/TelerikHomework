// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;

class OneSystemToAnyOther
{
    static void FromDecimal(long number, int toBase)
    {
        List<long> result = new List<long>();
        if (toBase > 10)
        {
            while (number > 0)
            {
                result.Add(number % toBase);
                number = number / toBase;
            }
            result.Reverse();
            foreach (var item in result)
            {
                switch (item)
                {
                    case 10: Console.Write('A'); break;
                    case 11: Console.Write('B'); break;
                    case 12: Console.Write('C'); break;
                    case 13: Console.Write('D'); break;
                    case 14: Console.Write('E'); break;
                    case 15: Console.Write('F'); break;
                    default: Console.Write(item); break;
                }
            }
        }
        else
        {
            while (number > 0)
            {
                result.Add(number % toBase);
                number = number / toBase;
            }
            result.Reverse();
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
    }
    static long ToDecimal(string input,int fromBase)
    {
        if (fromBase > 10)
        {
            int number = 0;
            long result = 0;
            for (int i = 0, p = input.Length - 1; i <= input.Length - 1; i++, p--)
            {
                switch (input[i])
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                    default: number = (int)input[i] - 48; break;
                }
                result += number * (long)Math.Pow(fromBase, p);
            }
            return result;
        }
        else
        {
            long a = long.Parse(input);
            long sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                long lastDigit = a % 10;
                sum = sum + lastDigit * (long)(Math.Pow(fromBase, i));
                a = a / 10;
            }
            return sum;
        }
    }
    static void Main()
    {
        Console.Write("Enter base s to convert number from - range[2 <= s <= 16]:");
        int fromBase = int.Parse(Console.ReadLine());
        Console.Write("Enter number in {0}-based numeral system:",fromBase);
        string number = Console.ReadLine();
        Console.Write("Enter base d to convert number to - range[2 <= d <= 16]:");
        int toBase = int.Parse(Console.ReadLine());
        if (fromBase >= 2 && fromBase <= 16 && toBase >= 2 && toBase <= 16)
        {
            Console.Write("Number in {0}-based numeral system to {1}-based:", fromBase, toBase);
            FromDecimal(ToDecimal(number, fromBase), toBase);
            Console.WriteLine();
        }
        else
        Console.WriteLine("Invalid input"); return;
    }
}
