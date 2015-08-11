//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        Console.Write("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = (number / 100) % 10;
        bool isSeven = (thirdDigit == 7);
        Console.WriteLine("Is third digit from right to left 7? {0}", isSeven ? "Yes" : "No");
    }
}