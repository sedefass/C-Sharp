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
        a *= 0.17;
        //a = Math.Round(a, 3);
        Console.WriteLine("{0:0.000}", a);
    }
}
