using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Today;
        string date = today.ToString("dd.MM.yyyy г.");
        Console.WriteLine(date);
        Console.WriteLine(DateTime.Today);
    }
}

