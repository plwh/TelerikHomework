/* Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. Define two new classes Triangle and 
Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle). Define
class Square and suitable constructor so that at initialization height must be kept equal to width and implementthe CalculateSurface() method. Write a
program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array. */

namespace _01.Shapes
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            Shape[] diffShapes =
            {
                new Square(4),
                new Rectangle(3,4),
                new Triangle(3.5,4)
            };

            foreach(Shape shape in diffShapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
