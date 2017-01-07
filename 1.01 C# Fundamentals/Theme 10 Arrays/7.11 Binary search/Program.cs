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

        int key = int.Parse(Console.ReadLine());

        Array.Sort(arr);
        int index = binarySearch(arr, 0, arr.Length - 1, key);
        Console.WriteLine(index);
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

    static int binarySearch(int[] arr, int lowerBound, int upperBound, int key)
    {
        int position = (lowerBound + upperBound) / 2;

        while((arr[position] != key) && (lowerBound <= upperBound))
        {
            if(arr[position] > key)
            {
                upperBound = position - 1;
            }
            else
            {
                lowerBound = position + 1;
            }
            position = (lowerBound + upperBound) / 2;            
        }

        if (lowerBound <= upperBound)
        {
            return position;
        }
        else
        {
            return -1;
        }
    }
}

