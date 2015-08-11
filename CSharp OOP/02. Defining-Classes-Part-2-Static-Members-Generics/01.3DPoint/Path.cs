// Problem 4: Create a class Path to hold a sequence of points in the 3D space.

using System;
using System.Collections.Generic;

namespace _01._3DPoint
{
    public class Path
    {
        private List<ThreeDPoint> points;

        public Path()
        { 
            points = new List<ThreeDPoint>();
        }

        public List<ThreeDPoint> Points
        {
            get { return points; }
        }

        public void AddPoint(ThreeDPoint point)
        {
            points.Add(point);
        }

        public void AddPoint(double x, double y, double z)
        {
            this.points.Add(new ThreeDPoint(x, y, z));
        }
    }
}
