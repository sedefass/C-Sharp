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

        int[] arr = new int[n + 1];
        int[] used = new int[n + 1];

        Permutation(1, n, arr, used);

    }

    static void Print(int n, int[] arr)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void Permutation(int i, int n, int[] arr, int[] used)
    {
        for (int j = 1; j <= n; j++)
        {
            if (used[j] == 0)
            {
                arr[i] = j;
                used[j] = 1;
                if (i == n)
                {
                    Print(n, arr);
                }
                else
                {
                    Permutation(i + 1, n, arr, used);
                }
                used[j] = 0;
            }
        }
    }
}
