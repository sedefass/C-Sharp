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

        arr = selectionSort(arr);

        printArray(arr);

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

    static int[] selectionSort(int[] arr)
    {
        int length = arr.Length;

        for(int i=0; i<length-1; i++)
        {
            for(int j=i+1; j<length; j++)
            {
                if (arr[j] < arr[i])
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        return arr;
    }

    static void printArray(int[] arr)
    {
        int length = arr.Length;
        for(int i=0; i<length; i++)
        {
            Console.WriteLine(arr[i]);
        }      
    }
}
