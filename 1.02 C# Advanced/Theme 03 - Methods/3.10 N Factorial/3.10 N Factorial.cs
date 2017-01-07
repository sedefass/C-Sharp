using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ////test with 100
        //string temp1 = "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000";
        //string temp2 = "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000";
        //Console.WriteLine(temp1.Equals(temp2));

        int n = int.Parse(Console.ReadLine());
        PrintResult(CalculateFactorial(n));
    }

    static int[,] CalculateFactorial(int input)
    {
        int[,] result = new int[4096, 2];
        result[0, 0] = 1;
        result[0, 1] = 1;

        while (input >= 1)
        {
            result = MultiplyArrayWithInt(result, input);
            input--;
        }
        return result;
    }

    static int[,] MultiplyArrayWithInt(int[,] arr, int number)
    {
        int[,] result = new int[4096, 2];
        for (int i = 0; i < arr.Length && arr[i, 1] == 1; i++)
        {
            int temp = arr[i, 0] * number;
            if (temp == 0)
            {
                result[i, 0] += 0;
                result[i, 1] = 1;
            }
            int br = 0;
            while (temp > 0)
            {
                result[i + br, 0] += temp % 10;
                result[i + br, 1] = 1;
                temp /= 10;
                br++;
            }
        }
        return result;
    }

    static void PrintResult(int[,] arr)
    {
        StringBuilder temp = new StringBuilder();
        for (int i = 0; i < arr.Length && arr[i, 1] == 1; i++)
        {
            temp.Append(arr[i, 0]);
        }
        string result = ReverseString(temp.ToString());
        Console.WriteLine(result);
    }

    static string ReverseString(string s)
    {
        if (s == null) return null;

        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
