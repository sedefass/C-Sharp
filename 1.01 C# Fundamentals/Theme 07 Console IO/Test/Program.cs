using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int number = -125;
        string str;
        if (number < 0)
        {
            str = Convert.ToString(number, 2).PadLeft(64,'1');
        }
        else
        {
            str = Convert.ToString(number, 2).PadLeft(64, '0');
        }
        string result = Convert.ToInt64(str, 2).ToString();
        Console.WriteLine(result);

    }
}

