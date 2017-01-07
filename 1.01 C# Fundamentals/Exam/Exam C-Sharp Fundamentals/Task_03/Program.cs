using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        bool condition = true;

        //string something = "on a given destiny not gettinging...";
        //Console.WriteLine(something.Length);
        //something = Reverse(something);
        //Console.WriteLine(something);

        StringBuilder output = new StringBuilder();
        int line = 1;

        do
        {
            string readLine1 = Console.ReadLine();
            if (!readLine1.Equals("end"))
            {
                string readLine2 = Console.ReadLine();
                if (!readLine2.Equals("end"))
                {
                    string readLine3 = Console.ReadLine();
                    if (!readLine3.Equals("end"))
                    {



                        int s = int.Parse(readLine1);
                        int k = int.Parse(readLine2);
                        string str = readLine3;

                        int length = str.Length;
                        int start = 0;
                        int end = length;


                        if (s >= 0)
                        {
                            start = s;
                        }
                        else
                        {
                            start = length + s;
                        }

                        if (k >= 0)
                        {
                            end = k;
                        }
                        else
                        {
                            end = end + k;
                        }

                        int augment = 1;
                        if (line % 2 == 0)
                        {
                            augment = 4;
                        }
                        else
                        {
                            augment = 3;
                        }
                        line++;

                        for (int i = start; i <= end; i += augment)
                        {
                            output.Append(str[i]);
                        }



                    }
                    else
                    {
                        condition = false;
                    }
                }
                else
                {
                    condition = false;
                }
            }
            else
            {
                condition = false;
            }         
        }
        while (condition);

        string result = output.ToString();
        Console.WriteLine(result);
    }

    public static string Reverse(string str)
    {
        char[] array = str.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
