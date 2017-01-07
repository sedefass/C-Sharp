using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());

        string binaryNum = Convert.ToString(number, 2).PadLeft(64, '0');

        char[] substitution = binaryNum.ToCharArray();
        int length = substitution.Length;

        char temp = substitution[length-1-3];     
        substitution[length - 1 - 3] = substitution[length - 1 - 24];
        substitution[length - 1 - 24] = temp;

        temp = substitution[length - 1 - 4];
        substitution[length - 1 - 4] = substitution[length - 1 - 25];
        substitution[length - 1 - 25] = temp;

        temp = substitution[length - 1 - 5];
        substitution[length - 1 - 5] = substitution[length - 1 - 26];
        substitution[length - 1 - 26] = temp;

        string result = Convert.ToInt64(new string(substitution), 2).ToString();

        Console.WriteLine(result);
    }
}


/*
    static uint ExchangeBits(uint number)
    {
        // 3, 4 and 5 bits
        byte first = (byte)((number >> 3) & 7); // ... & 111 (7 in dec) => gets 3 signs anytime

        // 24, 25, 26 bits
        byte second = (byte)((number >> 24) & 7); // ... & 111 (7 in dec) => gets 3 signs anytime

        // Example: 111 ^ 001 = 110
        // Intermediate point of comparison
        byte firstXORsecond = (byte)(first ^ second);

        number = (uint)(number ^ (firstXORsecond << 24));
        number = (uint)(number ^ (firstXORsecond << 3));

        return number;
    }
    
    static void Main(string[] args)
    {
        uint number = 1073709056;

        Console.WriteLine("Old number {0,-10} to binary -> {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        number = ExchangeBits(number);
        Console.WriteLine("New number {0,-10} to binary -> {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
    }
*/
