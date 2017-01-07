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
        PrintResult(IntegerCalculations(arr));

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

    static double[] IntegerCalculations(int[] arr)
    {
        double[] result = new double[5];
        result[0] = int.MaxValue;
        result[1] = int.MinValue;
        result[4] = 1;
        //[0]min [1]max [2]avg [3]sum [4]product
        for (int i = 0; i < arr.Length; i++)
        {
            if (result[0] > arr[i])
            {
                result[0] = arr[i];
            }
            if (result[1] < arr[i])
            {
                result[1] = arr[i];
            }
            result[3] += arr[i];
            result[4] *= arr[i];
        }
        result[2] = result[3] / arr.Length;
        return result;
    }

    static void PrintResult(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 2)
            {
                Console.WriteLine("{0:0.00}", arr[i]);
            }
            else
            {
                Console.WriteLine("{0:0.##}", arr[i]);
            }

        }
    }

}

