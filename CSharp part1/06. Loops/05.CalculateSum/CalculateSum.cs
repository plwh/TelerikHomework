/* Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point. */

using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter x:");
        int x = int.Parse(Console.ReadLine());
        double sum = 0;
        int factorial = 1;
        double power = 0;
        for (int k = 1; k <= n; k++)
        {
            factorial *= k;
            power = Math.Pow(x,k);
            sum += (factorial / power);       
        }
        Console.WriteLine("{0:F5}",sum+1);
    }
}

