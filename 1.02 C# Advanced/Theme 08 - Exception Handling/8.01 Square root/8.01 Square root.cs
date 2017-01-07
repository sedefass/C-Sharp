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
            double input = double.Parse(Console.ReadLine());
            if (input < 0)
            {
                throw new ArithmeticException();
            }
            Console.WriteLine("{0:0.000}", Math.Sqrt(input));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

