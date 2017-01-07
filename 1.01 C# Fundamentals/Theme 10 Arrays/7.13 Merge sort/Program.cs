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
        int[] arr = createArray(n);

        List<int> list = new List<int>(arr);
        list = mergeSort(list);

        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }

    static int[] createArray(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void printArray(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine(arr[arr.Length - 1]);
    }

    static List<int> mergeSort(List<int> intList)
    {
        if (intList.Count <= 1)
        {
            return intList;
        }
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int middle = intList.Count / 2;
        for (int i = 0; i < middle; i++)
        {
            left.Add(intList[i]);
        }
        for (int i = middle; i < intList.Count; i++)
        {
            right.Add(intList[i]);
        }
        left = mergeSort(left);
        right = mergeSort(right);
        return merge(left, right);
    }

    static List<int> merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    addAndRemove(left, result);
                }
                else
                {
                    addAndRemove(right, result);
                }
            }
            else if (left.Count > 0)
            {
                addAndRemove(left, result);
            }
            else
            {
                addAndRemove(right, result);
            }
        }
        return result;
    }

    private static void addAndRemove(List<int> removeFrom, List<int> addTo)
    {
        addTo.Add(removeFrom[0]);
        removeFrom.RemoveAt(0);
    }
}
