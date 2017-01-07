using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:0.00} {1:0.00}",2*radius*Math.PI,Math.Pow(radius,2)*Math.PI);
    }
}

