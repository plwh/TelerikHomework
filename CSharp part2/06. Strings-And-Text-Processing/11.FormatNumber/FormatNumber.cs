// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
// Format the output aligned right in 15 symbols.

using System;
using System.Text;
using System.Globalization;
using System.Threading;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter an integer number:");
        int number = int.Parse(Console.ReadLine());
        string dec = String.Format("{0,15:D}", number);
        string hex = String.Format("{0,15:X}", number);
        string percentage = String.Format("{0,15:P}", number/100.00);
        string scNotation = String.Format("{0,15:E}", number);
        Console.WriteLine("Decimal:{0} Hexadecimal:{1}\nPercentage:{2} Scientific notation:{3}", dec, hex,percentage,scNotation);
    }
}

