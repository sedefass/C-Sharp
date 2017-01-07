using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());

        double max = a;

        for(int i=0; i<4; i++)
        {
            a = double.Parse(Console.ReadLine());
            if (max < a)
            {
                max = a;
            }
        }

        Console.WriteLine(max);
    }
}

