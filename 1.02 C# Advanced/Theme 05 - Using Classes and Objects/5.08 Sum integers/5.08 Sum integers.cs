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
        int sum = 0;
        for (int i = 0; i < tokens.Length; i++)
        {
            sum += int.Parse(tokens[i]);
        }
        Console.WriteLine(sum);
    }
}

