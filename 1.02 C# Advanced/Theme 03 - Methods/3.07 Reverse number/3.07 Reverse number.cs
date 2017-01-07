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
        Console.WriteLine(ReverseNumber(input));
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine(ReverseNumber(number));
    }

    static string ReverseNumber(string input)
    {
        StringBuilder temp = new StringBuilder();
        for (int i = input.Length -1 ; i >= 0 ; i--)
        {
            temp.Append(input[i]);
        }
        return temp.ToString();
    }

    static string ReverseString(string s)
    {
        if (s == null) return null;

        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static double ReverseNumber(double number)
    {
        return double.Parse(ReverseString(number.ToString()));
    }


}
