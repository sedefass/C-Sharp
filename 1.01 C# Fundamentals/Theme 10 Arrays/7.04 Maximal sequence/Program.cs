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

        int[] array = createArray(n);

        Console.WriteLine(maxEqualSequenceCount(array));      
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

    static int maxEqualSequenceCount(int[] arr)
    {
        int length = arr.Length;
        int maxCount = 0;
        int currentCount = 1;

        for (int i = 1; i < length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentCount++;
                if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {                
                currentCount = 1;
            }
        }

        return maxCount;
    }
}

