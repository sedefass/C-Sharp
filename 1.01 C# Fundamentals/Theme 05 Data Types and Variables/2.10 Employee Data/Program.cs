using System;
class BankAccount9
{
    static void Main(string[] args)
    {
        string firstName = "Kalin";
        string secondName = "Nedelchev";
        string lastName = "Lambrev";
        long acount = 8900;
        string bankName = "Deutsch Bank";
        string iban = "DE12356987456";
        byte cardNum = 234;
        Console.WriteLine("Name: {0} {1} {2} \nAvailable Account: {3} \nBank Name: {4} \nIBAN: {5} \n{Card ID Number: {6}",
            firstName, secondName, lastName, acount, bankName, iban, cardNum);
    }
}