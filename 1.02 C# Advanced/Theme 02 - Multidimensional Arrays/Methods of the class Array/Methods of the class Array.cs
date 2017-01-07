using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[,,,,] multiDArr = new int[3, 3, 3, 3, 3];
        Console.WriteLine(multiDArr.Rank); //prints 5
    }
}
