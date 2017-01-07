using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        ////1. Text.Split()
        //string[] split = text.Split(new string[] { word }, StringSplitOptions.None);
        //Console.WriteLine(split.Length - 1);

        //2. While loop
        int index = 0;
        int counter = 0;
        int temp = 0;
        do
        {
            temp = text.IndexOf(word, index);
            index = temp + word.Length;
            if (temp >= 0)
            {
                counter++;
            }
        }
        while (temp >= 0);

        Console.WriteLine(counter);
    }
}
