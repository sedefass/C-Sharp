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

        Array.Sort(arr);
        int[] result = mostFrequentNumber(arr);

        Console.WriteLine("{0} ({1} times)", result[0], result[1]);
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

    //The input array must be sorted
    static int[] mostFrequentNumber(int[] arr)
    {
        int[] result = new int[2];
        int length = arr.Length;
        int number = arr[0];
        int currentCount = 1;
        int maxCount = 1;

        for (int i = 1; i < length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentCount++;
                if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    number = arr[i];
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        result[0] = number;
        result[1] = maxCount;
        return result;
    }
}
