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
        int thirdNumber = (number/100)%10;
        if(thirdNumber == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", thirdNumber % 10);
        }
    }
}

