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

        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;
        double avg = 0;

        for (int i = 1; i <= n; i++)
        {
            double a = double.Parse(Console.ReadLine());
            if (min > a)
            {
                min = a;
            }
            if (max < a)
            {
                max = a;
            }
            sum += a;
        }
        avg = sum / n;

        Console.WriteLine("min={0:0.00}", min);
        Console.WriteLine("max={0:0.00}", max);
        Console.WriteLine("sum={0:0.00}", sum);
        Console.WriteLine("avg={0:0.00}", avg);
    }
}
