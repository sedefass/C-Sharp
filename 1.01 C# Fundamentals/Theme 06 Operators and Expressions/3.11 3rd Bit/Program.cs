using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ulong n = ulong.Parse(Console.ReadLine());
        string s = Convert.ToString((long)n,2).PadLeft(64, '0');
        Console.WriteLine(s[s.Length-4]);
        

        /*
        //В задачата позицията е 3, тук е направено да се въвежда позицията на бита, който искаме
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        //в result се пази бита на позицията, която въвеждаме, разглеждана от дясно на ляво (100 е 1, 1000 е 0)
        int mask = 1 << position;
        int result = mask & number;
        result = result >> position;

        Console.WriteLine(result);
        */

    }
}

