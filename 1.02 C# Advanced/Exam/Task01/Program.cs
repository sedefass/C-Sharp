using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split( new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        //for (int i = 0; i < input.Length; i++)
        //{
        //    Console.WriteLine(input[i]);
        //}

        BigInteger[] numbers = new BigInteger[input.Length];
        BigInteger product = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            string temp = FindNumber(input[i]);
            //Console.Write(temp);

            numbers[i] = ConvertToDec(temp,8);
            //Console.WriteLine(" - " + numbers[i]);


            product *= numbers[i];
        }

        Console.WriteLine(product);

    }

    private static string FindNumber(string number)
    {
        number = number.Replace("hristofor", "3");
        number = number.Replace("vladimir", "7");

        number = number.Replace("hristo", "0");
        number = number.Replace("tosho", "1");
        number = number.Replace("pesho", "2");  
        number = number.Replace("vlad", "4");
        number = number.Replace("haralampi", "5");
        number = number.Replace("zoro", "6");
        
        return number;
    }

    public static BigInteger ConvertToDec(string number, int baseFrom)
    {
        BigInteger decNum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] > '9') 
            {
                decNum += (number[i] - '7') * (BigInteger)Math.Pow(baseFrom, (number.Length - 1 - i));
            }
            else
            {
                decNum += (number[i] - '0') * (BigInteger)Math.Pow(baseFrom, (number.Length - 1 - i));
            }
        }
        return decNum;
    }
}
