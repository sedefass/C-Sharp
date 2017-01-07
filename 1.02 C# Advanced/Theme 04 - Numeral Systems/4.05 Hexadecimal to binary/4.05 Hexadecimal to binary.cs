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
        Console.WriteLine(ConvertFromHexToBinary(number));
    }

    static string ConvertFromHexToBinary(string number)
    {
        StringBuilder result = new StringBuilder();

        string[] digits = new string[] { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
        string[] digitsS = new string[] { "", "1", "10", "11", "100", "101", "110", "111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };


        for (int i = 0; i < number.Length; i++)
        {
            char digit = number[i];
            int digitValue=0;

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

            if (i == 0)
            {
                result.Append(digitsS[digitValue]);
            }
            else
            {
                result.Append(digits[digitValue]);
            }
            
        }

        return result.ToString();
    }
}
