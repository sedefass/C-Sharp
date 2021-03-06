﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string system = "0123456789ABCDEF";
        Console.WriteLine(FromDecTo(number, 16, system));  
    }

    static string FromDecTo(ulong value, uint numeralBase, string system)
    {
        if (value == 0)
        {
            return "0";
        }

        StringBuilder result = new StringBuilder();
        StringBuilder temp = new StringBuilder();

        while (value != 0)
        {
            ulong digit = value % numeralBase;
            value /= numeralBase;

            temp.Append(system[(int)digit]);
        }

        string digits = temp.ToString();
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            result.Append(digits[i]);
        }

        return result.ToString();
    }
}
