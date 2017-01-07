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

        ulong[] primes = primeNumbers(n);
        int max = primes.Length - 1;
        Console.WriteLine(primes[max]);
    }

    static ulong[] primeNumbers(ulong n)
    {
        // it is n+1 because we start counting from 0
        bool[] temp = new bool[n + 1];
        // initially it is assumed that all number from 0 to n are primes (except 0 and 1)
        ulong count = 0;

        // initialization of bool[] temp is all temp[i] = false
        // I want to skip changing all of them to true
        // so if the value for i (representing the number) is false it means it is prime
        // or it is false if that i number has more than 2 dividers (1 and i)
        for (ulong i = 2; i < n + 1; i++)
        {
            if (!temp[i])
            {
                count++;
                for (ulong j = 2; (j * i) < n + 1; j++)
                {
                    temp[j * i] = true;
                }
            }
        }

        ulong[] primes = new ulong[count];
        ulong counter = 0;
        for (ulong i = 2; i < n + 1; i++)
        {
            if (temp[i] == false)
            {
                primes[counter] = i;
                counter++;
            }
        }

        return primes;
    }

}
