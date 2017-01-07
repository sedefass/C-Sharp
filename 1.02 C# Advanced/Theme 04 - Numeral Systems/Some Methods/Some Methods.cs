using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 16; i++)
        {
            Console.WriteLine("\"{0}\",\"{1}\", ",Convert.ToString(i,2),i);
        }

    }

    static int ParsInt(string number)
    {
        int result = 0;

        foreach (char digit in number)
        {
            result = result * 10 + (digit - '0');
        }

        return result;
    }

    static int ConvertToDecimal(string number, int numberalBase)
    {
        int result = 0;

        foreach (char digit in number)
        {
            result = result * numberalBase + (digit - '0');
        }

        return result;
    }

    static string FromDecTo(int value, int numeralBase)
    {
        if (value == 0)
        {
            return "0";
        }

        StringBuilder result = new StringBuilder();
        StringBuilder temp = new StringBuilder();

        if (value < -1)
        {
            result.Append("-");
            value *= -1;
        }

        while (value != 0)
        {
            int digit = value % numeralBase;
            value /= numeralBase;

            temp.Append(digit);
        }

        string digits = temp.ToString();
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            result.Append(digits[i]);
        }

        return result.ToString();
    }

    static string FromDecTo(int value, int numeralBase, string system)
    {
        if (value == 0)
        {
            return "0";
        }

        StringBuilder result = new StringBuilder();
        StringBuilder temp = new StringBuilder();

        if (value < -1)
        {
            result.Append("-");
            value *= -1;
        }

        while (value != 0)
        {
            int digit = value % numeralBase;
            value /= numeralBase;

            temp.Append(system[digit]);
        }

        string digits = temp.ToString();
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            result.Append(digits[i]);
        }

        return result.ToString();
    }

    static int ConvertFromHexToDecimal(string number)
    {
        int result = 0;

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
