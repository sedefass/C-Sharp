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
        string type = Console.ReadLine();

        int[,] matrix = new int[n, n];

        switch (type)
        {
            case "a":
                matrix = CreateMatrix_A(n);
                break;
            case "b":
                matrix = CreateMatrix_B(n);
                break;
            case "c":
                matrix = CreateMatrix_C(n);
                break;
            case "d":
                matrix = CreateMatrix_D(n);
                break;
            default:
                break;
        }

        PrintMatrix(matrix);
    }

    static int[,] CreateMatrix_A(int n)
    {
        int[,] matrix = new int[n, n];
        int number = 1;

        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n; i++)
            {
                matrix[i, j] = number;
                number++;
            }
        }

        return matrix;
    }

    static int[,] CreateMatrix_B(int n)
    {
        int[,] matrix = new int[n, n];
        int number = 1;

        for (int j = 0; j < n; j++)
        {
            if (j % 2 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[i, j] = number;
                    number++;
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[n - i - 1, j] = number;
                    number++;
                }
            }
        }

        return matrix;
    }

    static int[,] CreateMatrix_C(int n)
    {
        int[,] matrix = new int[n, n];
        int number = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            for (int x = i, y = 0; x < n; x++, y++)
            {
                matrix[x, y] = number;
                number++;
            }
        }

        for (int j = 1; j < n; j++)
        {
            for (int x = 0, y = j; y < n; x++, y++)
            {
                matrix[x, y] = number;
                number++;
            }
        }

        return matrix;
    }

    static int[,] CreateMatrix_D(int n)
    {
        int cellsCount = n * n;
        int direction = 0;
        int number = 1;
        int x = 0;
        int y = 0;
        int[,] matrix = new int[n, n];
        int decrease = 0;

        for (int i = 1; i <= cellsCount; i++)
        {
            matrix[x, y] = number;
            number++;
            if (direction % 4 == 0)
            {
                x++;
                if (x == n - 1 - decrease)
                {
                    direction++;
                }
            }
            else if (direction % 4 == 1)
            {
                y++;
                if (y == n - 1 - decrease)
                {
                    direction++;
                }
            }
            else if (direction % 4 == 2)
            {
                x--;
                if (x == 0 + decrease)
                {
                    direction++;
                    decrease++;
                }
            }
            else if (direction % 4 == 3)
            {
                y--;
                if (y == 0 + decrease)
                {
                    direction++;
                }
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
}
