using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15_BitSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            string binaryNum = Convert.ToString(number, 2).PadLeft(64, '0');

            char[] substitution = binaryNum.ToCharArray();
            int length = substitution.Length;

            for (int i = 0; i < k; i++)
            {
                char temp = substitution[length - 1 - i - p];
                substitution[length - 1 - i - p] = substitution[length - 1 - i - q];
                substitution[length - 1 - i - q] = temp;
            }

            string result = Convert.ToInt64(new string(substitution), 2).ToString();

            Console.WriteLine(result);
        }
    }
}
