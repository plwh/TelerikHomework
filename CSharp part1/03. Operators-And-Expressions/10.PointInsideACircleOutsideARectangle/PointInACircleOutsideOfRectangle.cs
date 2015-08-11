/* Write an expression that checks for given point (x, y) if it is
 * within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). */

using System;

class PointInACircleOutsideOfRectangle
{
    static void Main()
    {
        Console.Write("Please enter point coordinates:\n x=");
        double x = double.Parse(Console.ReadLine());
        Console.Write(" y=");
        double y = double.Parse(Console.ReadLine());
        int center_x = 1, center_y = 1;
        double radius = 1.5;
        bool inCircle = ((x - center_x) * (x - center_x) + (y - center_y) * (y - center_y) <= radius * radius);
        bool inRectangle  = x>=-1 && x<=5 && y>=-1 && y<=1;
        Console.WriteLine("\nIs point inside circle K({1,1},1.5) and\noutside rectangle R(top=1, left=-1, width =6, height=2)?");
        if (inCircle && !inRectangle)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

