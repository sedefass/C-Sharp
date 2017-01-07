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
        Console.WriteLine(LargerThanNeighbours(array));
    }

    static int LargerThanNeighbours(int[] array)
    {
        int result = 0;
        if (array.Length > 1)
        {
            //if (array[0] > array[1])
            //{
            //    result++;
            //}
            //if (array[array.Length - 1] > array[array.Length - 2])
            //{
            //    result++;
            //}
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    result++;
                }
            }
        }
        else
        {
            //if (array.Length == 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return 1;
            //}
            return 0;
        }
        return result;
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

