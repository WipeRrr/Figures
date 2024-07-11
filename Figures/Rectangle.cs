

namespace Figures
{
    public class Rectangle:IShape
    {
        public double SideLength { get; set; }
        public double SideWidth { get; set; }
        public Rectangle(double sideLength, double sideWidth)
        {
            SideLength = sideLength;
            SideWidth = sideWidth;
        }

        
       
    }
}
