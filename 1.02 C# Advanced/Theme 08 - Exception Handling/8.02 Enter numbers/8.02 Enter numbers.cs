using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        try
        {          
            int[] array = new int[12];
            array[0] = 1;
            array[11] = 100;
            int a;
            int b = array[0];

            for (int i = 1; i < 11; i++)
            {
                a = int.Parse(Console.ReadLine());
                array[i] = ReadNumber(a,b);
                b = array[i];
            }

            Console.WriteLine(String.Join(" < ", array));
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }
    }

    static int ReadNumber(int number, int check)
    {
        if (number <= check || number <= 0 || number >= 100)
        {
            throw new Exception();
        }

        return number;
    }

}

