using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int a = number / 1000;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;
        Console.WriteLine("{0}", a + b + c + d);
        Console.WriteLine("{3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("{3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("{0}{2}{1}{3}", a, b, c, d);
    }
}

