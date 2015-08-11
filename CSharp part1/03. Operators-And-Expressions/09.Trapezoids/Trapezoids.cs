//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Please enter side a:");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Please enter side b:");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Please enter height:");
        double height = double.Parse(Console.ReadLine());
        double area = height * (sideA + sideB) / 2;
        Console.WriteLine("Trapezoid with side a={0}, side b={1} and height={2} has area {3}", sideA, sideB,height,area);
    }
}
