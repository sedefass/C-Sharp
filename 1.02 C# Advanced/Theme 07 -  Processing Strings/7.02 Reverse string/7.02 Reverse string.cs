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

        ////1. Manual Reversal
        //string output1 = "";
        //for (int i = input.Length - 1; i >= 0; i--)
        //{
        //    output1 += input[i];
        //}
        //Console.WriteLine(output1);

        ////2.Array.Reverse()
        //char[] inputarray = input.ToCharArray();
        //Array.Reverse(inputarray);
        //string output2 = new string(inputarray);
        //Console.WriteLine(output2);

        //3.LINQ
        string output3 = new string(input.ToCharArray().Reverse().ToArray());
        Console.WriteLine(output3);
    }
}
