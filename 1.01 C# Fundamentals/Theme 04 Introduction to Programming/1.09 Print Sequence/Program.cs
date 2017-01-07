using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 2;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(a);
            if (a < 0)
            {
                a = -1 * (a - 1);
            }
            else
            {
                a = -1 * (a + 1);
            }
        }
    }
}
