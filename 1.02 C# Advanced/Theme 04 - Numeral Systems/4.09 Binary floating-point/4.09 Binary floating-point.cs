using System;
using System.Globalization;
using System.Threading;

class BinaryFloatingPoint
{
    static void Main()
    {
        // input
        Console.Write("Enter a floating-point number with single precision: ");
        float number = float.Parse(Console.ReadLine());
        // check and record sign
        int sign = number < 0 ? 1 : 0;

        // work further on absolute value of the number
        number = Math.Abs(number);

        // applying the FloatNumberToBinary(number) method
        string binary = FloatNumberToBinary(number);

        // 0.1 (Exponent: 01111011) \ 1.1 (Exponent: 01111111) \ 2.2 (Exponent: 10000000)
        if ((int)number == 0 || (int)number == 1)
        {
            binary += "0";
        }

        // printing
        Console.WriteLine("\nSign: {0} {1}", sign, sign == 1 ? "(minus)" : "(plus)");
        Console.WriteLine("Exponent: {0}", GetExponent(binary));
        Console.WriteLine("Mantissa: {0}\n", GetMantissa(binary));
    }

    // convert to binary
    static string FloatNumberToBinary(float number)
    {
        int dec = BitConverter.ToInt32(BitConverter.GetBytes(number), 0);
        return Convert.ToString(dec, 2);
    }

    // get exponent
    static string GetExponent(string binary)
    {
        return binary.Substring(0, 8);
    }

    // get mantissa
    static string GetMantissa(string binary)
    {
        return binary.Substring(8);
    }
}