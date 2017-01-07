using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        if (a % 7 == 0 && a % 5 == 0)
        {
            Console.WriteLine("true " + a);
        }
        else
        {
            Console.WriteLine("false " + a);
        }
    }
}

