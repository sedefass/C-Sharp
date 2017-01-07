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
        int n = int.Parse(Console.ReadLine());
        StringBuilder temp = new StringBuilder();

        for (int i = 0; i < n - 1; i++)
        {
            temp.Append(Console.ReadLine()).Append(" ");
        }
        temp.Append(Console.ReadLine());

        string text = temp.ToString();
        //Console.WriteLine(text);

        string[] sentances = text.Split(new char[] { '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
        string symbols = ExtractSymbols(text);

        string result = "";

        for (int i = 0, j = 0; i < sentances.Length; i++)
        {
            //Console.WriteLine("sentace " + i + ": " + sentances[i] + symbols[i]);
            if (sentances[i].Equals("") || sentances[i].Equals(" ") || sentances[i].Equals("  "))
            {

                continue;
            }


            int index = sentances[i].IndexOf(word);
            //Console.WriteLine(index);
            if (index >= 0)
            {
                if (symbols[j] == '.')
                {
                    int start = index + word.Length;
                    int length = sentances[i].Length - start;
                    result = sentances[i].Substring(start, length);
                }
                else
                {
                    int start = 0;
                    int length = index - 1;
                    result = sentances[i].Substring(start, length);
                }
                break;
            }
            j++;          
        }

        Console.WriteLine(CalculateResult(result, word.Length));


    }

    private static long CalculateResult(string text, int length)
    {
        long result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ')
            {
                result += text[i] * length;
            }
        }

        return result;
    }

    private static string ExtractSymbols(string text)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '.' || text[i] == '!')
            {
                result.Append(text[i]);
            }
        }

        return result.ToString();
    }
}
