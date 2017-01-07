using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //entering an array from the console
        string[] tokens = Console.ReadLine().Split(' ');
        int[] array = new int[tokens.Length];
        for (int i = 0; i < tokens.Length; i++)
        {
            array[i] = int.Parse(tokens[i]);
        }
        //or
        int[] myInts = Array.ConvertAll(tokens, int.Parse);
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine(string.Join(", ", myInts));

        Console.WriteLine("==============");

        //way to transform an array into a string
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = new int[]{ 1, 2, 3, 4, 5 };
        Console.WriteLine(string.Join(", ", array1));
        Console.WriteLine(string.Join(" - ", array2));
        string str1 = string.Join(", ", array1);
        //doesnt work properly with multy-dimensional arrays
        int[,] array3 =
        {
            {1, 2, 3, 4 },
            {5, 6, 7, 8 }
        };
        string str3 = string.Join(", ", array3);
        Console.WriteLine(str3);

        Console.WriteLine("==============");

        //Approach for entering a jaggered array from the console
        int n = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[n][];
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            jaggedArray[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine(string.Join(", ", jaggedArray[i])); ;
        }

        Console.WriteLine("==============");


    }
}
