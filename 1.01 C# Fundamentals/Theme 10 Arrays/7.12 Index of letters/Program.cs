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

        printLettersIndex(input);
    }

    static void printLettersIndex(string input)
    {
        int length = input.Length;
        for (int i = 0; i < length; i++)
        {
            char ch = input[i];
            if ('a' <= ch && ch <= 'z')
            {
                Console.WriteLine((int)(ch - 'a'));
            }
            else if ('A' <= ch && ch <= 'Z')
            {
                Console.WriteLine((ch - 'A'));
            }
        }
    }
}
