/* Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators. */

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        double c = double.Parse(Console.ReadLine());
        double product = a * b * c;
        if (product < 0)
        {
            Console.WriteLine("-");
        }
        else if (product > 0)
        {
            Console.WriteLine("+");
        }
        else 
        {
            Console.WriteLine("0");
        }
    }        
}

