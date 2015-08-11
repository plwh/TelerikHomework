/* Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality. */

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter a binary number:");
        string binaryNumber = Console.ReadLine();
        long a = long.Parse(binaryNumber);
        long sum = 0;
        for(int i=0;i<binaryNumber.Length;i++)
        {
            long lastDigit = a % 10;
            sum = sum + lastDigit * (long)(Math.Pow(2, i));
            a = a / 10;                  
        }
        Console.WriteLine("Binary to decimal:{0}",sum);
    }      
}

