using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        sbyte n = sbyte.Parse(Console.ReadLine());

        double result = 1;

        for (double i = 1; i <= n; i++)
        {
            result *= (i*(i+n) /((i+1)*i) );
        }

        Console.WriteLine(result);
    }
}
