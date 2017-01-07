using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Dictionary<int, string> NameOfDigits = new Dictionary<int, string>()
    {
        {0,"zero"},
        {1,"one"},
        {2,"two"},
        {3,"tree"},
        {4,"four"},
        {5,"five"},
        {6,"six"},
        {7,"seven"},
        {8,"eight"},
        {9,"nine"}
    };

    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        NameOfLastDigit(input);
    }

    static void NameOfLastDigit(int input)
    {
        int lastDigit = Math.Abs(input % 10);
        Console.WriteLine(NameOfDigits[lastDigit]);
    }
}
