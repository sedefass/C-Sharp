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

        int[] arr = new int[k + 1];

        Combination(1, arr, n, k);
    }

    static void Combination(int i, int[] arr, int n, int k)
    {
        for (int j = arr[i - 1] + 1; j <= n; j++)
        {
            arr[i] = j;
            if (i == k)
            {
                Print(k, arr);
            }
            else
            {
                Combination(i + 1, arr, n, k);
            }
        }
    }

    static void Print(int k, int[] arr)
    {
        for (int i = 1; i <= k; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
