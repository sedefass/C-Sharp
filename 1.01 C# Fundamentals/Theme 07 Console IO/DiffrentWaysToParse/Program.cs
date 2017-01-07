using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());

        int num2;
        if (int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine(num2);
        }
        else
        {
            Console.WriteLine("Not a valid number");
        }

        int a = 5;
        print(a); //а става локално 6 и се принтира
        Console.WriteLine(a); //но глобалната а си остава 6
        print1(out a); //вкарва ме си а във функцията, ноя инициализираме наново(тя не влиза със свойта стойност а само с референцията си)
        Console.WriteLine(a);//променя се глобалното а
        print2(ref a);//пчечата локалното а, което е дефакто глобалното а
        Console.WriteLine(a);// променя глобалното а
    }

    //създава се така локална променлива, която няма нищо общо с реалната освен началаната стойност
    static void print(int a)
    {
        a++;
        Console.WriteLine(a);
    }

    //когато искаме да инициализираме стойност използваме out
    //ако не я инициализираме ни дава грешка, защото тя няма стойност
    //локалната и глобалната а са един и същи обект
    static void print1(out int a)
    {
        a = 3;
        Console.WriteLine(a);
    }

    //директно работим с глобалната, не се създава локална
    static void print2(ref int a)
    {
        a++;
        Console.WriteLine(a);
    }
}

