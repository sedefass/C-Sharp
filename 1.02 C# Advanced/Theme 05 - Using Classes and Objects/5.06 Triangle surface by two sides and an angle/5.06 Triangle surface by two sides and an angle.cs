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
        double angle;

        public Triangle(double side1, double side2, double angle)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.angle = angle;
        }

        public double getArea()
        {
            double angle = this.angle * Math.PI / 180;
            return Math.Sin(angle)*side1*side2/2;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(side1, side2, angle);
        Console.WriteLine("{0:0.00}", triangle.getArea());
    }
}

