/* Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
 * and solves it (prints its real roots). */

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Quadratic Equation solver (ax^2+bx+c=0)");
        Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());
        if (a == 0)
        {
           Console.WriteLine("\"a\" cannot be zero");
           return;
        }
        Console.Write("Enter b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        double c = double.Parse(Console.ReadLine());
        double D = b * b - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("Equation has no real roots");
        }
        else if (D == 0)
        {
            Console.WriteLine("There are two equal roots - x1=x2={0}", (-b) / (2 * a));
        }
        else
        {
           Console.WriteLine("There are two roots - x1={0}; x2={1}", (-b + Math.Sqrt(D))/(2*a), (-b - Math.Sqrt(D))/(2*a));
        }
    }
}

