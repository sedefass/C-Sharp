using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int wantedSum;
    static int numberOfAddends;
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
        Console.Write("Enter sum: ");
        wantedSum = int.Parse(Console.ReadLine());
        Console.Write("Enter number of elements in the sum: ");
        numberOfAddends = int.Parse(Console.ReadLine());

        int[] subset = new int[n];
        for (int elementsInSubset = 1; elementsInSubset <= n; elementsInSubset++)
        {
            GenerateSubset(subset, arr, 0, 0, elementsInSubset);
        }

        if (!solution)
        {
            Console.WriteLine("Ain't no subset of {0} elements with sum {1}.", numberOfAddends, wantedSum);
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
        if (elementsInSubset != numberOfAddends)
        {
            return;
        }
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
