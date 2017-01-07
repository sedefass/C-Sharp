using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = CreateArray();
        Array.Sort(arr);
        //Array.Reverse(arr);
        Console.WriteLine(string.Join(" ",arr));
    }

    static int[] CreateArray()
    {
        int n = int.Parse(Console.ReadLine());
        int[] result = new int[n];
        string[] tokens = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            result[i] = int.Parse(tokens[i]);
        }
        return result;
    }
}
