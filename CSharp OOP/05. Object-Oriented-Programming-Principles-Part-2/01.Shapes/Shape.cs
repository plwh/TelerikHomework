﻿
namespace _01.Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width,double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get{ return this.width; }
            set{ this.width = value; }
        }

        public double Height
        {
            get{ return this.height; }
            set{ this.height = value; }
        }

        public abstract double CalculateSurface();
    }
}
