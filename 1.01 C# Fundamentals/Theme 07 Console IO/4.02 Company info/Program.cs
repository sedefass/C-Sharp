using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyPhoneNumber = Console.ReadLine();
        string companyFaxNumber = Console.ReadLine();
        string companyWebSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerPhoneNumber = Console.ReadLine();

        if(companyFaxNumber == "")
        {
            companyFaxNumber = "(no fax)";
        }

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);
        Console.WriteLine("Fax: {0}", companyFaxNumber);
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",
            managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}

