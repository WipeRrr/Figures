using System;
using Figures;
public class GetExpression
{
    public IShape GetShapeFromUser()
    {
       
        try
        {
            
            Console.WriteLine("Select a shape:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
         
                Console.WriteLine("\n\n\n\n\n\nInvalid input. Please enter a number.\n");
                return null;
            }

            if (choice == 1)
            {
                Console.Write("Enter side length of the square: ");
                if (!double.TryParse(Console.ReadLine(), out double sideLength) || sideLength < 0)
                {
                    Console.WriteLine("\n\n\n\n\nInvalid input. Please enter a valid number for the side length.\n");
                    return null;
                }
                return new Square(sideLength);
            }

            else if (choice == 2)
            {
                Console.Write("Enter length of the rectangle: ");
                if (!double.TryParse(Console.ReadLine(), out double sideLength) || sideLength < 0)
                {
                    Console.WriteLine("\n\n\n\n\nInvalid input. Please enter a valid number for the length.\n");
                    return null;
                }

                Console.Write("Enter width of the rectangle: ");
                if (!double.TryParse(Console.ReadLine(), out double sideWidth) || sideLength < 0)
                {
                    Console.WriteLine("\n\n\n\n\nInvalid input. Please enter a valid number for the width.\n");
                    return null;
                }
                return new Rectangle(sideLength, sideWidth);
            }

            else
            {
                Console.WriteLine("\n\n\n\n\nInvalid choice.\n");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}\n");
            return null;
        }

    }
}