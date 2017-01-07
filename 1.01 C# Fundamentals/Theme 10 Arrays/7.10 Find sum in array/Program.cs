using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string inputLine = Console.ReadLine();
        string[] tokens = inputLine.Split(new[] { ", " }, StringSplitOptions.None);
        int[] numbers = Array.ConvertAll(tokens, int.Parse);
        //Console.WriteLine(string.Join(", ", numbers));

        int sum = int.Parse(Console.ReadLine());

        Console.WriteLine(sumInArray(numbers, sum));
    }

    static string sumInArray(int[] arr, int sum)
    {
        string result = "";
        int length = arr.Length;
        int tempSum = 0;
        int start = 0;
        int end = -1;

        for (int i = 0; i < length; i++)
        {
            tempSum += arr[i];
            if (sum == tempSum)
            {
                end = i;
                break;
            }
            else if (sum < tempSum)
            {
                while (tempSum > sum)
                {
                    tempSum -= arr[start];
                    start++;
                }
                if (sum == tempSum)
                {
                    end = i;
                    break;
                }
            }
        }

        //it is better to use StringBuilder till the final result
        StringBuilder sb = new StringBuilder();
        if (end >= 0)
        {
            for (int i = start; i < end; i++)
            {
                sb.Append(arr[i]);
                sb.Append(", ");
            }
            sb.Append(arr[end]);
        }

        result = sb.ToString();
        return result;
    }
}
