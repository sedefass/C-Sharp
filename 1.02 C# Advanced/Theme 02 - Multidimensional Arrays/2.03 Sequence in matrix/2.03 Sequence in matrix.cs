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

        string[,] matrix = CreateMatrix(n, m);
        //Console.WriteLine("================");
        //PrintMatrix(matrix);

        Console.WriteLine(FindMaxSequence(matrix));
    }

    static string[,] CreateMatrix(int n, int m)
    {
        string[,] matrix = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = tokens[j];
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

    static int FindMaxSequence(string[,] matrix)
    {
        int result = 1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                    int counter = 1;
                    for (int k = i + 1; k < matrix.GetLength(0); k++)
                    {
                        if (matrix[i, j] == matrix[k, j])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    result = Math.Max(result, counter);
                    counter = 1;

                    for (int l = j + 1; l < matrix.GetLength(1); l++)
                    {
                        if (matrix[i, j] == matrix[i, l])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    result = Math.Max(result, counter);
                    counter = 1;

                    for (int k = i + 1, l = j + 1; k < matrix.GetLength(0) && l < matrix.GetLength(1); k++, l++)
                    {
                        if (matrix[i, j] == matrix[k, l])
                        {
                            counter++;
                        }
                    }
                    result = Math.Max(result, counter);
                    counter = 1;              
            }
        }

        return result;
    }

}
