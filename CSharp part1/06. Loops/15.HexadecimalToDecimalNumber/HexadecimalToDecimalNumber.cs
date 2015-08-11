/* Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality. */

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number:");
        string input = Console.ReadLine();
        int number = 0;
        long result = 0;
        for (int i = 0,p=input.Length-1;i<=input.Length-1;i++,p--)
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
            result += number * (long)Math.Pow(16, p);
        }
        Console.WriteLine("Hexadecimal to decimal:{0}",result);
    }   
}

