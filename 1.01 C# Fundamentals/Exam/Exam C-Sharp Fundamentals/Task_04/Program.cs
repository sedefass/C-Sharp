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
        //printArray(arr);

        for (int i = 0; i < n -1; i++)
        {
            Console.Write("{0}{1} ", arr[i] % 10, arr[i+1] / 10);
        }
        Console.WriteLine();
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write("{0} ", arr[i] + arr[i+1]);
        }

    }

    static int[] createArray(int n)
    {
        int[] arr = new int[n];
        int length = arr.Length;

        for(int i=0; i<length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        return arr;
    }

    static void printArray(int[] arr)
    {
        int length = arr.Length;

        for (int i = 0; i < length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
    }
}
