using System;

namespace DefiningClassesPart1
{
    // Problem 1
    public class Display
    {
        private double size;
        private int numberOfColors;

        // Problem 5
        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
        // Problem 2
        public Display() : this(4.7, 256) { }

        public Display(double size) : this(size, 4096) { }

        public Display(double size, int colors)
        {
            this.Size = size;
            this.NumberOfColors = colors;
        }
        // Problem 4
        public override string ToString()
        {
            return String.Format(" Size: {0} inches\n Number of colors: {1}",
                                  Size, NumberOfColors);
        }
    }
}

