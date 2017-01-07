using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        StringBuilder result = new StringBuilder("");
        //if (input <= 0)
        //{
        //    result.Append("1");
        //}

        while (input != 0)
        {
            result.Append(input % 2);
            input /= 2;
        }

        int length = result.Length;

        for (int i = length - 1; i > -1; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
