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

        int a = number / 100;
        int b = (number / 10) % 10;
        int c = number % 10;
        //Console.WriteLine("{0} {1} {2}", a, b, c);

        double result = 0;

        if (c != 0)
        {
            if (b % 2 == 0)
            {
                result = (a + b) * c;
            }
            else
            {
                result = a * b / (double)c;
            }
        }
              
        Console.WriteLine("{0:0.00}", result);

    }
}
