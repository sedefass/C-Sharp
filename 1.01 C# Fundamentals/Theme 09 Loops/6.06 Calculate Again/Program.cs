using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        uint k = uint.Parse(Console.ReadLine());

        double result = 1;

        //checks for overflow (if n=100 and k=1 as it is in the task clause there is no overflow for max double)
        checked
        {
            if (n - k >= 0)
            {
                for (uint i = k + 1; i <= n; i++)
                {
                    result *= i;
                }
            }
            else
            {
                for (uint i = n + 1; i <= k; i++)
                {
                    result /= i;
                }
            }
        }
        
        Console.WriteLine(result);
    }
}

