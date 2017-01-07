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

        quickSort(ref arr);
        foreach (int item in arr)
        {
            Console.WriteLine(item);
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

    static void quickSort(ref int[] input)
    {
        System.Collections.Stack stack = new System.Collections.Stack();
        int pivot;
        int pivotIndex = 0;
        int leftIndex = pivotIndex + 1;
        int rightIndex = input.Length - 1;

        stack.Push(pivotIndex);//Push always with left and right
        stack.Push(rightIndex);

        int leftIndexOfSubSet, rightIndexOfSubset;

        while (stack.Count > 0)
        {
            rightIndexOfSubset = (int)stack.Pop();//pop always with right and left
            leftIndexOfSubSet = (int)stack.Pop();

            leftIndex = leftIndexOfSubSet + 1;
            pivotIndex = leftIndexOfSubSet;
            rightIndex = rightIndexOfSubset;

            pivot = input[pivotIndex];

            if (leftIndex > rightIndex)
                continue;

            while (leftIndex < rightIndex)
            {
                while ((leftIndex <= rightIndex) && (input[leftIndex] <= pivot))
                    leftIndex++;    //increment right to find the greater 
                                    //element than the pivot

                while ((leftIndex <= rightIndex) && (input[rightIndex] >= pivot))
                    rightIndex--;//decrement right to find the 
                                 //smaller element than the pivot

                if (rightIndex >= leftIndex)   //if right index is 
                                               //greater then only swap
                    swapElement(ref input, leftIndex, rightIndex);
            }

            if (pivotIndex <= rightIndex)
                if (input[pivotIndex] > input[rightIndex])
                    swapElement(ref input, pivotIndex, rightIndex);

            if (leftIndexOfSubSet < rightIndex)
            {
                stack.Push(leftIndexOfSubSet);
                stack.Push(rightIndex - 1);
            }

            if (rightIndexOfSubset > rightIndex)
            {
                stack.Push(rightIndex + 1);
                stack.Push(rightIndexOfSubset);
            }
        }
    }

    static void swapElement(ref int[] arr, int left, int right)
    {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
    }
}

