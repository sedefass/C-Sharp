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
        int[,] check = new int[n, m];



        Console.WriteLine(FindMaxArea(matrix, check));
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

    static int FindMaxArea(int[,] matrix, int[,] check)
    {
        int result = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (check[i, j] == 0)
                {
                    int temp1 = 0;
                    int temp2 = DFS(matrix, check, i, j, ref temp1);
                    if (temp2 > result)
                    {
                        result = temp2;
                    }
                }          
            }
        }
        return result;
    }

    static int DFS(int[,] matrix, int[,] check, int a, int b, ref int result)
    {
        check[a, b] = 1;
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        //so recursevely we can increase the result with every new check of an element in the matrix
        result++;

        if (b + 1 < columns && matrix[a, b] == matrix[a, b + 1])
        {
            if (check[a, b + 1] == 0)
            {
                check[a, b + 1] = 1;

                DFS(matrix, check, a, b + 1, ref result);
            }
        }
        if (b - 1 >= 0 && matrix[a, b] == matrix[a, b - 1])
        {
            if (check[a, b - 1] == 0)
            {
                check[a, b - 1] = 1;

                DFS(matrix, check, a, b - 1, ref result);
            }
        }
        if (a + 1 < rows && matrix[a, b] == matrix[a + 1, b])
        {
            if (check[a + 1, b] == 0)
            {
                check[a + 1, b] = 1;

                DFS(matrix, check, a + 1, b, ref result);
            }
        }
        if (a - 1 >= 0 && matrix[a, b] == matrix[a - 1, b])
        {
            if (check[a - 1, b] == 0)
            {
                check[a - 1,b] = 1;

                DFS(matrix, check, a - 1, b, ref result);
            }
        }

        return result;
    }
}
