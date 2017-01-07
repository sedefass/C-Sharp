using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        
        switch (input1)
        {
            case "integer":
                long a = long.Parse(Console.ReadLine());
                Console.WriteLine(++a);
                break;
            case "real":
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(++b);
                break;
            default:
                Console.WriteLine(Console.ReadLine() + "*");
                break;
        }
    }
}

