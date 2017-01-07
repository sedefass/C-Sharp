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
        double side;
        double altitude;

        public Triangle(double side, double altitude)
        {
            this.side = side;
            this.altitude = altitude;
        }

        public double getArea()
        {
            return this.altitude * this.side / 2;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        double side = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(side, altitude);
        Console.WriteLine("{0:0.00}", triangle.getArea());
    }
}

