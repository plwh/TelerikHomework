// Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter a decimal number:");
        long decimalNumber = long.Parse(Console.ReadLine());
        string result = "";
        if (decimalNumber == 0)
        {
            result = "0";
        }
        else
        {
            while (decimalNumber > 0)
            {
                long remainder = decimalNumber % 16;
                decimalNumber = decimalNumber / 16;
                switch (remainder)
                {
                    case 10: result = "A" + result; break;
                    case 11: result = "B" + result; break;
                    case 12: result = "C" + result; break;
                    case 13: result = "D" + result; break;
                    case 14: result = "E" + result; break;
                    case 15: result = "F" + result; break;
                    default: result = remainder + result; break;
                }
            }
        }
        Console.WriteLine("Decimal to hexadecimal:{0}", result);
    }
}

