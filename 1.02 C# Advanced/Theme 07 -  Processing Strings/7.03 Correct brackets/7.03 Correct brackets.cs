using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int result = CheckBrackets(input);
        Console.WriteLine(result == 0 ? "Correct" : "Incorrect");
    }

    private static int CheckBrackets(string input)
    {
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                counter++;
            }
            else if (input[i] == ')')
            {
                counter--;
            }

            if (counter < 0)
            {
                return -1;
            }

        }

        return counter;
    }
}
