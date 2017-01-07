using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int wantedSum;
    static bool solution = false;

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter sum S: ");
        wantedSum = int.Parse(Console.ReadLine());

        int[] subset = new int[n];
        for (int elementsInSubset = 1; elementsInSubset <= n; elementsInSubset++)
        {
            GenerateSubset(arr, subset, 0, 0, elementsInSubset);
        }

        if (!solution)
        {
            Console.WriteLine("Ain't no subset with sum {0}.", wantedSum);
        }
    }

    static void GenerateSubset(int[] arr, int[] subset, int index, int current, int elementsInSubset)
    {
        if (index == elementsInSubset)
        {
            CheckSubsets(subset, elementsInSubset);
            return;
        }

        for (int i = current; i < arr.Length; i++)
        {
            subset[index] = arr[i];
            GenerateSubset(arr, subset, index + 1, i + 1, elementsInSubset);
        }
    }

    static void CheckSubsets(int[] subset, int elementsInSubset)
    {
        int sum = 0;
        for (int i = 0; i < elementsInSubset; i++)
        {
            sum += subset[i];
        }
        if (sum == wantedSum)
        {
            for (int i = 0; i < elementsInSubset; i++)
            {
                Console.Write("{0} ", subset[i]);
            }
            Console.WriteLine();
            solution = true;
        }
    }
   
}
