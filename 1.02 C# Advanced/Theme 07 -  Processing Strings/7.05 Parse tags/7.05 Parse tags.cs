using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        string startWord = "<upcase>";
        string endWord = "</upcase>";
        int startWordLength = startWord.Length;
        int endWordLength = endWord.Length;

        int startIndex = text.IndexOf(startWord);
        int endIndex = text.IndexOf(endWord);

        string result = String.Copy(text);

        while (startIndex >= 0)
        {

            string substring = result.Substring(startIndex + startWordLength, endIndex - (startIndex + startWordLength));
            String replace = startWord + substring + endWord;
            String replacement = substring.ToUpper();
            // System.out.println(substring + " " + replace + " " + replacement);
            result = result.Replace(replace, replacement);
            // System.out.println(text);
            startIndex = result.IndexOf(startWord);
            endIndex = result.IndexOf(endWord);
        }

        Console.WriteLine(result);

    }

}
