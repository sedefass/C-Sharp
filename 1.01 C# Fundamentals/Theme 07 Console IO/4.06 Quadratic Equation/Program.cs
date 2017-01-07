using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double xx1 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        double xx2 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        double x1 = Math.Min(xx1, xx2);
        double x2 = Math.Max(xx1, xx2);

        double d = b * b / 4 - a * c;

        if (a == 0)
        {
            Console.WriteLine(-c / b);
        }
        else if (d > 0)
        {
            Console.WriteLine("{0:0.00}\n{1:0.00}", x1, x2);
        }
        else if (d == 0)
        {
            Console.WriteLine("{0:0.00}", x1);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}

