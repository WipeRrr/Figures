using System;
using System.Collections.Generic;

namespace Figures
{
    public class Calculate
    {
        public List<IShape> Shapes { get; set; }

        public Calculate(List<IShape> shapes)
        {
            Shapes = shapes;
        }
        public double Area()
        {
            double area = 0;
            foreach (var shape in Shapes) {

                if (shape is Square) {
                    area += Math.Pow((shape as Square).SideLength, 2);
                   
                }
                else if(shape is Rectangle)
                {
                    area += (shape as Rectangle).SideWidth * (shape as Rectangle).SideLength;
                    }
               

            }
            return area;
        }


        public double Perimeter()
        {
            double perimeter = 0;
            foreach (var shape in Shapes)
            {

                if (shape is Square)
                {
                    perimeter = Math.Pow((shape as Square).SideLength, 4);
                }
                else if (shape is Rectangle)
                {
                    perimeter += (shape as Rectangle).SideWidth*2 + (shape as Rectangle).SideLength*2;
                }
              

            }
              return perimeter;
        }
     



    }
}