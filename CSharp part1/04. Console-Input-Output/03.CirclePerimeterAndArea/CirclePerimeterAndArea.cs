/*Write a program that reads the radius r of a circle and prints its perimeter and area
formatted with 2 digits after the decimal point. */

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle radius:");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius,2);
        Console.WriteLine("Perimeter:{0:F2} Area:{1:F2}", perimeter, area);
    }
}

