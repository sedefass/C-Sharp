using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ushort a = ushort.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string hexadecimal = Convert.ToString(a, 16);
        string binaryForm = Convert.ToString(a, 2).PadLeft(16,'0');

        //От страница 177 нататък - обяснения за форматиране
        Console.WriteLine("{0,-4}|{1}|{2,-8:0.00}|{3,8:0.000}|",
            hexadecimal, binaryForm, b, c);


    }
}

