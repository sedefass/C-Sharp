using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        sbyte n = sbyte.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        
        for (int i = 0; i < n; i++)
        {
            int number = i + 1;
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = number;
                number++;
            }
        }

        printMaxtrix(matrix);
    }

    static void printMaxtrix(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column-1; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine(matrix[i, column - 1]);
        }
    }

    static void printMaxtrix2(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column - 1; j++)
            {
                Console.Write("{0,4}", matrix[i, j] + " ");
            }
            Console.WriteLine("{0,4}", matrix[i, column - 1]);
        }
    }
}

