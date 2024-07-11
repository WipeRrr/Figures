

using System;
using System.Collections.Generic;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new List<IShape>();
            array.Add(new Rectangle(1,2));
            array.Add(new Square(3));

            var calculator = new Calculate(array);


            var outputter = new CalculateOutputter(calculator);

            outputter.ToConsole();  
           

            Console.ReadLine();


        }
    }
}
