using System;

class Program
{
    static void Main(string[] args)
    {
        var userInput = Console.ReadLine();
        DateTime yearBorn;
        DateTime.TryParse(userInput, out yearBorn);
        DateTime now = DateTime.Today;
        int age = now.Year - yearBorn.Year;
        if (yearBorn > now.AddYears(-age)) age--;
        //DateTime today = Date.Today;
        //DateTime yearsOld = today - yearBorn;
        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}
