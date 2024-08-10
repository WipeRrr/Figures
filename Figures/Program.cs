using System;
using System.Collections.Generic;


namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shapes Calculator. With this program you can calculate the area and perimeter of selected shapes.\n");
            while (true)
            {
                var expression = new ExpressionReceiver();
                IShape shape = expression.GetShapeFromUser();

                if (shape != null)
                {
                    var shapes = new List<IShape> { shape };
                    var calculator = new Calculate(shapes);
                    var outputter = new CalculateOutputter(calculator);

                    outputter.ToConsole();
                }
             
            }
        }
    }
}
