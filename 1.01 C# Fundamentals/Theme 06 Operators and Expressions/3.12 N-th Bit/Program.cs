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
        int position = int.Parse(Console.ReadLine());

        string binaryNum = Convert.ToString(number, 2).PadLeft(64, '0');

        int bitIndex = (binaryNum.Length - 1) - position;

        Console.WriteLine(binaryNum[bitIndex]);
    }
}