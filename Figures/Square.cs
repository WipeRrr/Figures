namespace Figures
{
    public class Square:IShape
    {
        public double SideLength { get; set; }
        public Square(double sideLength)
        {
            SideLength = sideLength;
           
        }
    }
}
