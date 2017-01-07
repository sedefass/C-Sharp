using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int br = 0;

        for (int i=n+1; i<m; i++)
        {
            if (i % 5 == 0)
            {
                br++;
            }
        }

        Console.WriteLine(br);
    }
}

