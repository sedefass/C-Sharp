using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        char[] charSet1 = input1.ToArray();
        char[] charSet2 = input2.ToArray();

        bool check = false;
        int difference = 0;

        int length = Math.Min(charSet1.Length, charSet2.Length);
        for (int i = 0; i < length && !check; i++)
        {
            if (charSet1[i] != charSet2[i])
            {
                difference = charSet1[i] - charSet2[i];
                check = true;
            }
        }

        if (difference > 0)
        {
            Console.WriteLine(">");
        }
        else if (difference < 0)
        {
            Console.WriteLine("<");
        }
        else
        {
            if (charSet1.Length > charSet2.Length)
            {
                Console.WriteLine(">");
            }
            else if(charSet1.Length < charSet2.Length)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }

    }
}
