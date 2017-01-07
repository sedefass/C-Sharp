using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        sbyte n = sbyte.Parse(Console.ReadLine());
        string inputLine = Console.ReadLine();

        string[] tokens = inputLine.Split(' ');
        long[] numbers = Array.ConvertAll(tokens, long.Parse);

        long oddProduct = 1;
        long evenProduct = 1;

        for (int i = 0; i < n; i++)
        {
            long a = numbers[i];
            if (i % 2 == 1)
            {
                evenProduct *= a;
            }
            else
            {
                oddProduct *= a;
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}
