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

        //string[] sentances = text.Split( '.', '!', '?' );
        string[] sentances = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string symbols = ExtractSymbols(text);
        int symbolIndex = 0;

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < sentances.Length; i++)
        {
            if (sentances[i].IndexOf(word + " ") != -1 || sentances[i].IndexOf(" " + word) != -1)
            {
                sentances[i] += symbols[symbolIndex];   
                result.Append(sentances[i]);
                symbolIndex++;
            }
        }

        Console.WriteLine(result.ToString());
    }

    private static string ExtractSymbols(string text)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '.' || text[i] == '!' || text[i] == '?')
            {
                result.Append(text[i]);
            }
        }

        return result.ToString();
    }
}
