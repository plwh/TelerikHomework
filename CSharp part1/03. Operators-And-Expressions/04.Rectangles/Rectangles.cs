//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please enter width:");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please enter height:");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (width + height) * 2;
        double area = width * height;
        Console.WriteLine("Width:{0} Height:{1} Perimeter:{2} Area:{3}", width, height, perimeter, area);
    }
}
