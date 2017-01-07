using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int length = input.Length;

        double result = 0;

        for(int i=length-1; i>=0; i--)
        {
            if (input[i] == '1')
            {
                result += Math.Pow(2, length-i-1);
            }      
        }

        Console.WriteLine(result);
    }
}
