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
        sbyte k = sbyte.Parse(Console.ReadLine());

        double result = 1;
        double nk = n - k;

        for (double i = k + 1; i <= n; i++)
        {      
            result *= (i / (nk));
            nk--;
        }

        Console.WriteLine(result);
    }
}
