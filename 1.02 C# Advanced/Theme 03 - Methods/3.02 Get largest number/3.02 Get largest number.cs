using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string[] tokens = Console.ReadLine().Split(' ');
        int a = int.Parse(tokens[0]);
        int b = int.Parse(tokens[1]);
        int c = int.Parse(tokens[2]);

        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());

        Console.WriteLine(GetLarger(GetLarger(a, b), c));
    }

    static int GetLarger(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
