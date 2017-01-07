using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string[] tokens = Console.ReadLine().Split(' ');
        int n = int.Parse(tokens[0]);
        int m = int.Parse(tokens[1]);

        int[,] matrix = CreateMatrix(n, m);
        //PrintMatrix(matrix);

        Console.WriteLine(MaxSum(matrix,n,m));
    }

    static int[,] CreateMatrix(int n, int m)
    {
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(tokens[j]);
            }
        }
        return matrix;          
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine(matrix[i, matrix.GetLength(1) - 1]);
        }
    }

    static int MaxSum(int[,] inputMatrix, int n, int m)
    {
        int[] maxSumIndexes = new int[2];
        int maxSum = int.MinValue;

        for (int i = 0; i < n-2; i++)
        {
            for (int j = 0; j < m-2; j++)
            {
                int sum = 0;
                for (int k = 0; k < 3; k++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        sum += inputMatrix[i+k, j+l];
                    }
                }
                if(sum > maxSum)
                {
                    maxSum = sum;
                    maxSumIndexes[0] = i;
                    maxSumIndexes[1] = j;
                }
            }
        }

        return maxSum;
    }
}
