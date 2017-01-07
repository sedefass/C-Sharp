using System;

class Program
{
    static void Main(string[] args)
    {
        sbyte a = sbyte.Parse(Console.ReadLine());
        if (a % 2 != 0)
        {
            Console.WriteLine("odd " + a);
        }
        else
        {
            Console.WriteLine("even " + a);
        }
    }
}

