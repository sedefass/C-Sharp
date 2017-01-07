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
        Console.WriteLine(ConvertFromHexToDecimal(number));      
    }

    static long ConvertFromHexToDecimal(string number)
    {
        long result = 0;

        foreach (char digit in number)
        {
            int digitValue;

            if (char.IsDigit(digit))
            {
                digitValue = digit - '0';
            }
            else if ('a' <= digit && digit <= 'e')
            {
                digitValue = digit - 'a' + 10;
            }
            else
            {
                digitValue = digit - 'A' + 10;
            }

            result = 16 * result + digitValue;
        }

        return result;
    }
}
