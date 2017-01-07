using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[k];
        Combinations(arr, 0, 1);
    }

    static int elements = 5;
    static void Combinations(int[] array, int index, int currentNumber)
    {
        if (index == array.Length)
        {
            PrintResult(array);
        }
        else
        {
            for (int i = currentNumber; i <= elements; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1);
            }
        }

    }

    static void PrintResult(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
