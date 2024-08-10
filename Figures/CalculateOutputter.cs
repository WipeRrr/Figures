using System;

namespace Figures
{
    public class CalculateOutputter
    {
        public Calculate Calculate {  get; set; }

        public CalculateOutputter(Calculate calculate) 
        {
            Calculate = calculate;
        }

        public void ToConsole()
        {
            Console.WriteLine("\nArea: " + Calculate.GetTotalArea());
            Console.WriteLine("Perimeter: " + Calculate.GetTotalPerimeter());
            Console.WriteLine("-------------------------------------------------------------------------------------------");
        }
    }
}
 