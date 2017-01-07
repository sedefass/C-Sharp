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
        Console.WriteLine(ConvertToUnicode(input));
    }

    private static string ConvertToUnicode(string input)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            result.Append("\\u"+(((int)input[i]).ToString("X4")));
            //Console.WriteLine(Convert.ToUInt16(input[i]));
            
        }

        return result.ToString();
    }
}
