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
        int k = int.Parse(Console.ReadLine());


        int[] array = createArray(n);
        Array.Sort(array);

        int maxSum = 0;

        for (int i = n - 1; i > n - 1 - k; i--)
        {
            maxSum += array[i];
        }

        Console.WriteLine(maxSum);
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

    //бях объркал условието на задачата
    static int maxSumOfKElements(int[] arr, int k)
    {
        int length = arr.Length;
        int maxSum = 0;
        int currentSum = 1;

        for (int i = 0; i < k; i++)
        {
            maxSum += arr[i];
        }
        currentSum = maxSum;

        for (int i = k; i < length; i++)
        {
            currentSum = currentSum - arr[i - k] + arr[i];
            if (maxSum < currentSum)
            {
                maxSum = currentSum;
            }
        }

        return maxSum;
    }
}
