using System;

class Program
{
    static void Main(string[] args)
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a + " " + b);
        int? c = a + 1;
        Console.WriteLine(c);

    }
}

