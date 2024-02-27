using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionWorkshop;

internal class Triangle
{
    double side1;
    double side2;
    double side3;

    public Triangle(double side1, double side2, double side3) 
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;

        if (!IsValidTriangle(side1, side2, side3))
        {
            throw new BadTriangleException("Invalid sides!");
        }
    }

    public double Perimeter()
    {
        double perimeter = side1 + side2 + side3;
        return perimeter;
    }

    public double Area()
    {
        double semi_perimeter = Perimeter() / 2;
        double area = Math.Sqrt(semi_perimeter * 
            (semi_perimeter - side1) *
            (semi_perimeter - side2) * 
            (semi_perimeter - side3));
        string format = area.ToString("0.##");
        double final = double.Parse(format);
        return final;
    }

    private static bool IsValidTriangle(double side1, double side2, 
        double side3)
    {  
        return side1 > 0 && side2 > 0 && side3 > 0 &&
        side1 + side2 > side3 &&
        side1 + side3 > side2 &&
        side2 + side3 > side1;
    }
}
