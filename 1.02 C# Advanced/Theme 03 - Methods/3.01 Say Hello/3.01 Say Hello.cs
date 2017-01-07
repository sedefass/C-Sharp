using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        SayHello();
    }

    static void SayHello()
    {
        //Console.WriteLine("Was is dein Name? ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}
