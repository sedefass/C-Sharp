using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        checkValues(str);
    }

    public static void checkValues(string str)
    {
        int length = str.Length;

        for(int i=0; i<length; i++)
        {
            Console.WriteLine("{0} - {1} ", i, str[i] );
        }
    }
}
