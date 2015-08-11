// Problem 3: Write a static class with a static method to calculate the distance between two points in the 3D space.

using System;

namespace _01._3DPoint
{
    public static class CalculateDistance
    {
        public static double CalcDistance(ThreeDPoint firstPoint, ThreeDPoint secondPoint)
        {
            double firstEquation = (secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X);
            double secondEquation = (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y);
            double thirdEquation = (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z);
            double distance = Math.Sqrt(firstEquation + secondEquation + thirdEquation);
            return distance;
        }
    }
}
