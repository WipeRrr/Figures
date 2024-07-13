using System;

namespace Figures
{
    public class Square : Rectangle
    {
        public double SquareSideLength { get; set; }
        public Square(double sideLength) : base(sideLength, sideLength)
        {
        }
    }
}
