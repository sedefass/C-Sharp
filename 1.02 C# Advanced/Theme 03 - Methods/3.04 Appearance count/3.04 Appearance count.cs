using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {      
        int[] numbers = CreateArray();
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(AppearanceCount(number,numbers));
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

    static int AppearanceCount(int number, int[] numbers)
    {
        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] == number)
            {
                result++;
            }
        }
        return result;
    }
}
