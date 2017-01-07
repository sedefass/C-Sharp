using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        Console.WriteLine(ConvertToDecimal(number,2));
    }

    static long ConvertToDecimal(string number, uint numberalBase)
    {
        long result = 0;

        foreach (char digit in number)
        {
            result = result * numberalBase + (digit - '0');
        }

        return result;
    }
}
