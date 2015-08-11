// Problem 1: Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//            Implement the ToString() to enable printing a 3D point.
// Problem 2: Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//            Add a static property to return the point O.

using System;

namespace _01._3DPoint
{
    public struct ThreeDPoint
    {
       private static readonly ThreeDPoint pointZero; 
       private double x;
       private double y;
       private double z;
        
       public double X
       {
           get { return this.x; }
           set { this.x = value; }
       }

       public double Y
       {
           get { return this.y; }
           set { this.y = value; }
       }

       public double Z
       {
           get { return this.z; }
           set { this.z = value; }
       }

       public static ThreeDPoint PointZero
       {
           get{ return pointZero; }
       }

       static ThreeDPoint()
       {
           pointZero = new ThreeDPoint(0, 0, 0);
       }

       public ThreeDPoint(double x, double y, double z):this()
       {
           this.X = x;
           this.Y = y;
           this.Z = z;
       }

       public override string ToString()
       {
           return String.Format("{0} {1} {2}", this.X, this.Y, this.Z);
       }
    }
}
