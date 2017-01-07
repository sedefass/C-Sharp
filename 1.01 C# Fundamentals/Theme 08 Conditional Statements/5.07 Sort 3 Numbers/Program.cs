using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double[] sort = new double[3];

        for(int i=0; i<3; i++)
        {
            sort[i] = double.Parse(Console.ReadLine());
        }

        Array.Sort(sort);

        Console.WriteLine("{2} {1} {0}",sort[0],sort[1],sort[2]);

        
    }
}
