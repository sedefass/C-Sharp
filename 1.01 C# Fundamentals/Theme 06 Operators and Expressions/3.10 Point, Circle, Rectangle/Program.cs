using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        string inCircle;
        string inRectangle;

        double radiusVector = Math.Sqrt(Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2));

        if (radiusVector <= 1.5)
        {
            inCircle = "inside";
        }
        else
        {
            inCircle = "outside";
        }

        if ((x < -1 || x > 5) || (y < -5 || y > 1))
        {
            inRectangle = "outside";
        }
        else
        {
            inRectangle = "inside";
        }

        /*
         if ((x >= -1 && x <= 5) && (y >= -5 && y <= 1))
        {
            inRectangle = "inside";
        }
        else
        {
            inRectangle = "outside";
        }
         */

        Console.WriteLine("{0} circle {1} rectangle", inCircle, inRectangle);
    }


}
