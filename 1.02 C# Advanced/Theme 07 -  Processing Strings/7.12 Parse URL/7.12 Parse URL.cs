using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        StringBuilder protocol = new StringBuilder();
        StringBuilder server = new StringBuilder();
        StringBuilder resource = new StringBuilder();

        string[] split = input.Split(new string[] { "://"},StringSplitOptions.RemoveEmptyEntries);

        protocol.Append(split[0]);

        int index = split[1].IndexOf("/");

        for (int i = 0; i < index; i++)
        {
            server.Append(split[1][i]);
        }

        for (int i = index; i < split[1].Length; i++)
        {
            resource.Append(split[1][i]);
        }

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}

