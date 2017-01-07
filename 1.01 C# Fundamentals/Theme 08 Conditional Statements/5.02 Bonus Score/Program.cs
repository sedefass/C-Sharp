using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());

        if(a>=1 && a<=3)
        {
            a *= 10;
            Console.WriteLine(a);
        }
        else if(a>=4 && a<=6)
        {
            a *= 100;
            Console.WriteLine(a);
        }
        else if(a>=7 && a<=9)
        {
            a *= 1000;
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}

