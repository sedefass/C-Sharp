using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = createArray(n);

        Console.WriteLine(maxSumOfArray(arr));
    }

    static int[] createArray(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static int maxSumOfArray(int[] arr)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;

        int start = 0;
        int startTemp = 0;
        int end = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (currentSum <= 0)
            {
                currentSum = 0;
                startTemp = i;
            }

            currentSum += arr[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = startTemp;
                end = i;
            }
        }

        return maxSum;
    }
}

