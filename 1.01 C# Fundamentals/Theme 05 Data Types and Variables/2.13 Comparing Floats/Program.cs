using System;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        a = Math.Round(a, 6);

        double b = double.Parse(Console.ReadLine());
        b = Math.Round(b, 6);

        if (a == b)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

