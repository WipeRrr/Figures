

using System;

namespace Figures
{
    public class Rectangle : IShape
    {
        public double SideLength { get; set; }
        public double SideWidth { get; set; }
        public Rectangle(double sideLength, double sideWidth)
        {
            SideLength = sideLength;
            SideWidth = sideWidth;
        }


        public double GetArea()
        {
           return  SideWidth * SideLength;
        }

        public double GetPerimeter()
        {
           return 2* (SideWidth + SideLength);
        }
    }
}
