using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string inputLine = Console.ReadLine();

        string[] tokens = inputLine.Split(' ');
        int[] numbers = Array.ConvertAll(tokens, int.Parse);
        
        int a = numbers[0];
        int b = numbers[1];

        Console.WriteLine(GCD2(a, b));
    }

    static int GCD1(int a, int b)
    {
        int min = Math.Min(a, b);
        bool check = false;
        int result = 1;

        while (!check)
        {
            for (int i = min; i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    result = i;
                    check = true;
                    return result;
                }
            }
        }

        return 1;
    }

    static int GCD2(int a, int b)
    {
        int remaining;

        while (b != 0)
        {
            remaining = a % b;
            a = b;
            b = remaining;
        }

        return a;
    }
}

