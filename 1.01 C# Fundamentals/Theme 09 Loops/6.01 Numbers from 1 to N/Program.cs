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

        for(int i=1; i<n; i++)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine(n);
    }
}

