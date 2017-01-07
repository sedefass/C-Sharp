using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static Dictionary<string, string> BinnaryToHex = new Dictionary<string, string>()
    {
        { "0000","0" },
        { "0001","1" },
        { "1","1" },
        { "0010","2" },
        { "10","2" },
        { "0011","3" },
        { "11","3" },
        { "0100","4" },
        { "100","4" },
        { "0101","5" },
        { "101","5" },
        { "0110","6" },
        { "110","6" },
        { "0111","7" },
        { "111","7" },
        { "1000","8" },
        { "1001","9" },
        { "1010","A" },
        { "1011","B" },
        { "1100","C" },
        { "1101","D" },
        { "1110","E" },
        { "1111","F" }
    };

    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        Console.WriteLine(ConvertFromBinaryToHex(number));
    }

    static string ConvertFromBinaryToHex(string number)
    {
        StringBuilder result = new StringBuilder();

        int additive = number.Length % 4;
        if(additive > 0)
        {
            number = number.PadLeft(number.Length + 4- additive, '0');
        }


        for (int i = 0; i < number.Length; i+=4)
        {
            string temp = "";

            for (int j = i; j < i+4; j++)
            {
                temp += number[j]; 
            }

            result.Append(BinnaryToHex[temp]);
        }

        return result.ToString();
    }
}
