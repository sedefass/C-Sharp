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
        double b = double.Parse(Console.ReadLine());

        if(a<b)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(a);
        }
    }
}

