/* A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and 
a phone number.Write a program that reads the information about a company and its manager and prints it back on the console. */

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company address:");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number:");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number:");
        string faxNumber = Console.ReadLine();
        if (faxNumber.Length == 0)
        {
            faxNumber = "(no fax)";
        }
        Console.Write("Web site:");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name:");
        string managerFName = Console.ReadLine();
        Console.Write("Manager last name:");
        string managerLName = Console.ReadLine();
        Console.Write("Manager age:");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone:");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(@"{0}
Address: {1}
Tel. {2}
Fax: {3}
Web site: {4}
Manager: {5} {6} (age: {7}, tel. {8})",companyName,companyAddress, phoneNumber, faxNumber, webSite, managerFName, managerLName, managerAge, managerPhone);


    }
}
