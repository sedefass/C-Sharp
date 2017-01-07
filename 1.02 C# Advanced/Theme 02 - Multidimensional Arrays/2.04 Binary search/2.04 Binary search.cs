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

        int[] arr = CreateArray(n);
        Console.WriteLine(string.Join(", ", arr));

        Array.Sort(arr);
        Console.WriteLine(string.Join(", ", arr));

        int pos = Array.BinarySearch(arr, k);
        //https://msdn.microsoft.com/en-us/library/2cy9f6wb(v=vs.110).aspx

        Console.WriteLine("=============================");
        Console.WriteLine("result of returned index = " + pos);
        Console.WriteLine("Bitwise operator ~ to returned index = " + ~pos);
        Console.WriteLine("========================================");

        FindSmaller(arr, pos);
        FindGreater(arr, pos);

    }

    static int[] CreateArray(int n)
    {
        int[] array = new int[n];
        Random rng = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = rng.Next(1, 100);
        }
        return array;
    }

    static void FindSmaller(int[] arr, int pos)
    {
        if (pos < 0)
        {
            pos = ~pos - 1;
        }
        if (pos < 0)
        {
            Console.WriteLine("There is no number in the array which is SMALLER or equal to K.");
        }
        else
        {
            Console.WriteLine("The closest SMALLER or equal number to K is: " + arr[pos]);
        }
    }

    static void FindGreater(int[] arr, int pos)
    {
        if (pos < 0)
        {
            pos = ~pos;
        }
        if (pos >= arr.Length)
        {
            Console.WriteLine("There is no number in the array which is GREATER or equal to K.");
        }
        else
        {
            Console.WriteLine("The closest GREATEST or equal number to K is: " + arr[pos]);
        }
    }
}
