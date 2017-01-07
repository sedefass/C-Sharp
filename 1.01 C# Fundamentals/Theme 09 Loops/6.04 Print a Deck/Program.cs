using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        char ch = char.Parse(Console.ReadLine());
        int a = (int) ch;
        
        if(a>=49 && a <= 57)
        {
            a -= 48;
        }
        else
        {
            switch (ch)
            {
                case 'J':
                    a = 11; break;
                case 'Q':
                    a = 12; break;
                case 'K':
                    a = 13; break;
                case 'A':
                    a = 14; break;
                default:
                    a = 0; break;
            }
        }

        
        
        for(int i=2; i<=a; i++)
        {
            if (i <= 10)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds",i);
            }
            else if (i == 11)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
            }
            else if(i == 12)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
            }
            else if(i == 13)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
            }
            else
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "A");
            }
        }
        
    }
}
