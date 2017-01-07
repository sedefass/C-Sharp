using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        /*
        long number = long.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        char value = char.Parse(Console.ReadLine());

        string binaryNum = Convert.ToString(number, 2).PadLeft(64, '0');

        int bitIndex = (binaryNum.Length - 1) - position;
        char[] substitution = binaryNum.ToCharArray();
        substitution[bitIndex] = value;

        string result = Convert.ToInt64(new string(substitution), 2).ToString();

        Console.WriteLine(result);
        */

        ulong number = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        //Console.WriteLine("Binary representation: " + Convert.ToString(number, 2).PadLeft(16, '0'));

        if (value == 0)
        {
            ulong mask = (ulong)~(1 << position);
            ulong result = number & mask;
            //Console.WriteLine("Modified value:        " + Convert.ToString(result, 2).PadLeft(16, '0'));      
            Console.WriteLine(result);
        }
        else
        {
            ulong mask = (ulong)1 << position;
            ulong result = number | mask;
            //Console.WriteLine("Modified value:        " + Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine(result);
        }

    }
}