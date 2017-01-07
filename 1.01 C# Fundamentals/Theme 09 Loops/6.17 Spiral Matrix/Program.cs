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

        int[,] matrix = createMatrix(n);
        
        printMaxtrix(matrix);
    }

    static int[,] createMatrix(int n)
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
                y++;
                if (y == n - 1 - decrease)
                {
                    direction++;
                }
            }
            else if (direction % 4 == 1)
            {
                x++;
                if (x == n - 1 - decrease)
                {
                    direction++;
                }
            }
            else if (direction % 4 == 2)
            {
                y--;
                if (y == 0 + decrease)
                {
                    direction++;
                    decrease++;
                }
            }
            else if (direction % 4 == 3)
            {
                x--;
                if (x == 0 + decrease)
                {
                    direction++;
                }
            }
        }
        return matrix;
    }

    static void printMaxtrix(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column - 1; j++)
            {
                Console.Write(matrix[i, j]+" ");
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
                Console.Write("{0,4}",matrix[i, j] + " ");
            }
            Console.WriteLine("{0,4}",matrix[i, column - 1]);
        }
    }
}
