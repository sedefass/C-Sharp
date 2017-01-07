using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(ShortToBinary(number));
    }
    
    static string ShortToBinary(int number)
    {
        if (number == 0)
        {
            return "".PadLeft(16,'0');
        }

        StringBuilder result = new StringBuilder();
        StringBuilder temp = new StringBuilder();
        char sign = 'x';

        if (number > 0)
        {
            sign = '0';
            while (number != 0)
            {
                int digit = number % 2;
                number /= 2;

                temp.Append(digit);
            }
        }
        else
        {
            sign = '1';
            number = -1 * number - 1;
            while (number != 0)
            {
                int digit = number % 2;
                number /= 2;

                temp.Append(1-digit);
            }
        }

        string digits = temp.ToString();
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            result.Append(digits[i]);
        }

        if (sign == '0')
        {
            return result.ToString().PadLeft(16, sign);
        }

        return result.ToString().PadLeft(16, sign);
    }
}
