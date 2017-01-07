using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int counterZeroes = 0;

        if (number == 5)
        {
            counterZeroes = 1;
        }
        else
        {
            // first way
            for (int i = 5; number / i >= 1; i *= 5)
            {
                counterZeroes += number / i;
            }

            // second way
            //for (int power5 = 5; power5 <= number; power5 *= 5)
            //{
            //    counterZeroes += number / power5;
            //}
        }

        Console.WriteLine(counterZeroes);

    }
}
