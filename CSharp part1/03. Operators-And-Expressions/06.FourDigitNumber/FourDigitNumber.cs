/* Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101). */

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = (number / 1000) % 10;
        int secondDigit = (number / 100) % 10;
        int thirdDigit = (number / 10) % 10;
        int fourthDigit = number % 10;
        int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine(@"
        Sum of digits:{0}
        Number in reversed order:{4}{3}{2}{1}
        Last digit in 1st position:{4}{1}{2}{3}
        2nd and 3rd digits exchanged:{1}{3}{2}{4}", sum, firstDigit, secondDigit, thirdDigit, fourthDigit);
    }
}

