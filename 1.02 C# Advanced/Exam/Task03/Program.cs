using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        char[,] cave = CreateCave();
        //PrintCave(cave);

        int[] position = StartPosition(cave);
        int startX = position[1];
        int startY = position[0];
        //Console.WriteLine(position[0] + " " + position[1]);

        string direction = Console.ReadLine();
        int snakeLength = 3;
        int counter = 0;


        for (int i = 0; i < direction.Length; i+=2)
        {
            counter++;
            if (counter % 5 == 0)
            {
                snakeLength--;
            }
            if (snakeLength == 0)
            {
                Console.WriteLine("Sneaky is going to starve at [{0},{1}]", position[0], position[1]);
                return;
            }

            if (direction[i] == 'a' || direction[i] == 'A')
            {
                position[1]--;
            }
            else if (direction[i] == 's' || direction[i] == 'S')
            {
                position[0]++;
            }
            else if (direction[i] == 'd' || direction[i] == 'D')
            {
                position[1]++;
            }
            else if (direction[i] == 'w' || direction[i] == 'W')
            {
                position[0]--;
            }

            if (position[0] >= cave.GetLength(0) /*|| position[1] < 0 || position[1] >= cave.GetLength(1)*/)
            {
                Console.WriteLine("Sneaky is going to be lost into the depths with length {0}", snakeLength);
                return;
            }

            if (position[0] < 0 /*|| position[1] < 0 || position[1] >= cave.GetLength(1)*/)
            {
                Console.WriteLine("Sneaky is going to get out with length {0}", snakeLength); ;
                return;
            }

            if (position[1] < 0)
            {
                position[1] = cave.GetLength(1) - 1;
                if (cave[position[0], position[1]] == '%')
                {
                    Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", position[0], position[1]);
                    return;
                }
            } else if(position[1] >= cave.GetLength(1))
            {
                position[1] = 0;
                if (cave[position[0], position[1]] == '%')
                {
                    Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", position[0], position[1]);
                    return;
                }
            }

            if (cave[position[0], position[1]] == '%')
            {
                Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", position[0], position[1]);
                return;
            }

            if (cave[position[0], position[1]] == '@')
            {
                snakeLength++;
                cave[position[0], position[1]] = '-';
            }

            if (cave[position[0], position[1]] == 'e')
            {
                Console.WriteLine("Sneaky is going to get out with length {0}", snakeLength);
                return;
            }

            //Console.WriteLine("{0},{1}", position[0], position[1]);
        }

        if (position[0] == startY && position[1] == startX)
        {
            Console.WriteLine("Sneaky is going to get out with length {0}", snakeLength);
        }
        else
        {
            Console.WriteLine("Sneaky is going to be stuck in the den at [{0},{1}]", position[0], position[1]);
        }

    }

    private static int[] StartPosition(char[,] cave)
    {
        int[] result = new int[2];

        for (int i = 0; i < cave.GetLength(0); i++)
        {
            for (int j = 0; j < cave.GetLength(1); j++)
            {
                if (cave[i, j] == 'e')
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }

        result[0] = -1;
        result[1] = -1;
        return result;
    }

    static char[,] CreateCave()
    {
        string[] dimensions = Console.ReadLine().Split('x');
        int rows = int.Parse(dimensions[0]);
        int columns = int.Parse(dimensions[1]);
        char[,] cave = new char[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string temp = Console.ReadLine();
            for (int j = 0; j < columns; j++)
            {
                cave[i, j] = temp[j];
            }
        }

        return cave;
    }

    static void PrintCave(char[,] cave)
    {
        for (int i = 0; i < cave.GetLength(0); i++)
        {
            for (int j = 0; j < cave.GetLength(1); j++)
            {
                Console.Write(cave[i, j]);
            }
            Console.WriteLine();
        }
    }

}
