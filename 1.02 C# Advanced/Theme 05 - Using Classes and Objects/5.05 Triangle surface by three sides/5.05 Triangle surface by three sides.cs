using _5._04_Triangle_surface_by_side_and_altitude;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._04_Triangle_surface_by_side_and_altitude
{
    public class Triangle
    {
        double side1;
        double side2;
        double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double getArea()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(side1, side2, side3);
        Console.WriteLine("{0:0.00}", triangle.getArea());
    }
}

