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

        int length = input.Length;
        char ch;
        int counter=0;

        for(int i=0; i>=0 && i<length;)
        {
            ch = input[i];
            if('a' <= ch && ch <= 'z')
            {
                i += ch - 'a' + 1;
            }
            else if ('A' <= ch && ch <= 'Z')
            {
                i -= ch - 'A' + 1;
            }
            else if (ch == '^')
            {
                Console.WriteLine("Djor and Djano are at the party at {0}!", counter);
                return;
            }
            else
            {
                Console.WriteLine("Wrong input!");
                return;
            }

            counter = i;
        }

        Console.WriteLine("Djor and Djano are lost at {0}!", counter);
    }
}
