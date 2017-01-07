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
        int[] arr1 = CreateArray();
        int[] arr2 = CreateArray();
        Console.WriteLine(string.Join(" ", SumOfArrays(arr1, arr2)));
    }

    static int[] CreateArray()
    {
        //int n = int.Parse(Console.ReadLine());      
        string[] tokens = Console.ReadLine().Split(' ');
        int[] result = new int[tokens.Length];
        for (int i = 0; i < tokens.Length; i++)
        {
            result[i] = int.Parse(tokens[i]);
        }
        return result;
    }

    static int[] SumOfArrays(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }
        return result;
    }
}
