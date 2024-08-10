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
        public double GetTotalArea()
        {
            double area = 0;
            foreach (var shape in Shapes) 
            {
              
                area += shape.GetArea();           

            }
            return area;
        }


        public double GetTotalPerimeter()
        {
            double perimeter = 0;
            foreach (var shape in Shapes)
            {
                perimeter += shape.GetPerimeter();

            }
              return perimeter;
        }

    }
}