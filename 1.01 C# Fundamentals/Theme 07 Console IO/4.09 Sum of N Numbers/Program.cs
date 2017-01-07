using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double a;
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            a = double.Parse(Console.ReadLine());
            sum += a;
        }

        Console.WriteLine(sum);
    }
}
