using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] cards = new string[] {"2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac", "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad", "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah", "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As" };

        int handsCount = int.Parse(Console.ReadLine());
        ulong[] hands = new ulong[handsCount];

        for (int i = 0; i < handsCount; i++)
        {
            hands[i] = ulong.Parse(Console.ReadLine());
            //if (temp >= 0)
            //{
                //hands[i] = Convert.ToString(temp, 2).PadLeft(52, '0');
            //}
            //else
            //{
            //    hands[i] = Convert.ToString(temp, 2).PadLeft(52, '1');
            //}
        }

        int[] count = new int[52];
        StringBuilder result = new StringBuilder();
        bool check = true;

        for (int i = 0; i < 32; i++)
        {
            long mask = 1 << i;
            for (int j = 0; j < handsCount; j++)
            {
                count[i] += ((hands[j] & mask) >> i);
            }

            if (count[i] == 0)
            {
                check = false;
            }

            if (count[i] % 2 != 0)
            {
                result.Append(cards[i] + " ");
            } 
        }

        for (int i = 0; i < hands.Length; i++)
        {
            int mask = 1 << 32;
            hands[i] = hands[i] >> 32;
        }

        for (int i = 0; i < 20; i++)
        {
            long mask = 1 << i;
            for (int j = 0; j < handsCount; j++)
            {
                count[i] += ((hands[j] & mask) >> i);
            }

            if (count[i] == 0)
            {
                check = false;
            }

            if (count[i] % 2 != 0)
            {
                result.Append(cards[i+32] + " ");
            }
        }

        if (check == true)
        {
            Console.WriteLine("Full deck");
        }
        else
        {
            Console.WriteLine("Wa wa!");
        }
        Console.WriteLine(result);
    }

}
