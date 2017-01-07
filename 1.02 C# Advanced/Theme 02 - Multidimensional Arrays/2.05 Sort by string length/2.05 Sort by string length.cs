using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string[] beers =
    {
        "Zagorka", "Ariana", "Shumensko",
        "Astika", "Kamenitza", "Bolqrka",
        "Amstel"
    };
        Console.WriteLine("Unsorted: {0}", string.Join(", ", beers));
        // Elements of beers array are of string type,
        // which implement IComparable
        Array.Sort(beers);
        Console.WriteLine("Sorted: {0}", string.Join(", ", beers));
        // Result: Sorted: Amstel, Ariana, Astika,
        // Bolyarka, Kamenitza, Shumensko, Zagorka

        var sortedArray = from item in beers
                          orderby item.Length
                          select item;
        Console.WriteLine("Sorted: {0}", string.Join(", ", sortedArray));

        SortByLength(beers);
        Console.WriteLine("Sorted: {0}", string.Join(", ", beers));
    }

    static void SortByLength(string[] input)
    {
        //some code
    }
}
