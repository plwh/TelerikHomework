/* Write methods that calculate the surface of a triangle by given:
-Side and an altitude to it;
-Three sides;
-Two sides and an angle between them;
Use System.Math. */

using System;

class TriangleSurface
{
    static double CalcAreaWithAltitude(double side, double height)    
    {
        return (side * height) / 2;     
    }
    static double CalcAreaWithHeron(double sideA, double sideB, double sideC)
    {
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        
    }
    static double CalcAreaWithAngle(double sideA, double sideB, double angle)
    {
        return (sideA*sideB*Math.Sin(Math.PI * angle / 180)) / 2;
    }
    static void Main()
    {
        Console.Write(@"Calculate triangle surface by given:
1.Side and altitude to it
2.Three sides
3.Two sides and an angle between them
Choose an option from the menu above:");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: Console.Write("Enter side:");
                    double side = double.Parse(Console.ReadLine());
                    Console.Write("Enter altitude:");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area = {0}",CalcAreaWithAltitude(side, height));
                    break;
            case 2: Console.Write("Enter first side:");
                    double firstSide = double.Parse(Console.ReadLine());
                    Console.Write("Enter second side:");
                    double secondSide = double.Parse(Console.ReadLine());
                    Console.Write("Enter third side:");
                    double thirdSide = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area = {0}", CalcAreaWithHeron(firstSide,secondSide,thirdSide));
                    break;
            case 3: Console.Write("Enter first side:");
                    double sideOne = double.Parse(Console.ReadLine());
                    Console.Write("Enter second side:");
                    double sideTwo = double.Parse(Console.ReadLine());
                    Console.Write("Enter angle between them:");
                    double angleBetween = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area = {0}", CalcAreaWithAngle(sideOne, sideTwo, angleBetween));
                    break;
            default: Console.WriteLine("Invalid option!"); return;
        }
    }
}
