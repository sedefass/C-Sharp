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

        int[] arr1 = createArray(n);
        int[] arr2 = createArray(n);

        compareArrays(arr1, arr2);
    }

    static int[] createArray(int n)
    {
        int[] array = new int[n];
        for(int i =0; i<n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void compareArrays(int[] arr1, int[] arr2)
    {      
        if(arr1.Length != arr2.Length)
        {
            Console.WriteLine("Not equal");
            return;
        }

        int length = arr1.Length;

        for(int i=0; i<length; i++)
        {
            if(arr1[i] != arr2[i])
            {
                Console.WriteLine("Not equal");
                return;
            }
        }
        Console.WriteLine("Equal");
    }
}
