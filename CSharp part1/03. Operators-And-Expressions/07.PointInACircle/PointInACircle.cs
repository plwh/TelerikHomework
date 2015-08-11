//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Please enter point coordinates:\n x=");
        double x = double.Parse(Console.ReadLine());
        Console.Write(" y=");
        double y = double.Parse(Console.ReadLine());
        int center_x = 0,center_y = 0, radius = 2;
        if ((x - center_x) * (x - center_x) + (y - center_y) * (y - center_y) <= radius * radius)
        {
            Console.WriteLine("The point is inside a circle k({0,0},2)");
        }
        else
        {
            Console.WriteLine("The point is not inside a circle k({0,0},2)");
        }
    }
}
