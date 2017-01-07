using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ulong n = ulong.Parse(Console.ReadLine());

        if (n >= 1)
        {
            ulong[] fibonachi = new ulong[n];
            if (n == 1)
            {
                fibonachi[0] = 0;
            }
            else
            {
                fibonachi[0] = 0;
                fibonachi[1] = 1;
            }

            for (ulong i = 3; i <= n; i++)
            {
                fibonachi[i - 1] = fibonachi[i - 2] + fibonachi[i - 3];
            }

            for (ulong i = 0; i < n - 1; i++)
            {
                Console.Write(fibonachi[i] + ", ");
            }

            Console.WriteLine(fibonachi[n - 1]);
        }
        else
        {
            Console.WriteLine("0");
        }

        
    }
}
