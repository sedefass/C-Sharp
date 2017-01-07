using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1;
        int factorial = 1;

        for (int i=1; i<=n; i++)
        {
            factorial *= i;
            sum += factorial / (Math.Pow(x, i));
        }

        Console.WriteLine("{0:0.00000}",sum);
    }
}
