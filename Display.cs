using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionWorkshop;

internal class Display
{
    public void greet()
    {
        try
        {
            Triangle triangle = new Triangle(2, 3, 4);
            Console.WriteLine("Valid Triangle:");
            Console.WriteLine($"Perimeter: {triangle.Perimeter()}");
            Console.WriteLine($"Area: {triangle.Area()}");

            Console.WriteLine("\nInvalid Triangle:");
            Triangle badTriangle = new Triangle(2, 0, 4);
        }
        catch (BadTriangleException e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }
}
