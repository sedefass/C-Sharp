using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] array = CreateArray();
        Console.WriteLine(FirstLargerThanNeighbours(array));
    }

    static int FirstLargerThanNeighbours(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                return i;
            }
        }
        return -1;
    }

    static int[] CreateArray()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        string[] tokens = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(tokens[i]);
        }
        return array;
    }
}
