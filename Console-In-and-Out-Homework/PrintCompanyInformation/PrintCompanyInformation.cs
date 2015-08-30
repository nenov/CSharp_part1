using System;
class PrintCompanyInformation
{
    static void Main()
    {
        //A company has name, address, phone number, fax number, web site and manager.
        //The manager has first name, last name, age and a phone number.
        //Write a program that reads the information about a company and its manager and prints it back on the console.
        
        Console.Write("Company name:");
        string compName = Console.ReadLine();
        if(compName.Length==0)compName="(no company name)";
        Console.Write("Company address:");
        string compAddress = Console.ReadLine();
        if (compAddress.Length == 0) compAddress = "(no company address)";
        Console.Write("Phone number:");
        string phoneNum = Console.ReadLine();
        if (phoneNum.Length == 0) phoneNum = "(no number)";
        Console.Write("Fax number:");
        string faxNumber = Console.ReadLine();
        if (faxNumber.Length == 0) faxNumber = "(no fax)";
        Console.Write("Web site:");
        string webSite = Console.ReadLine();
        if (webSite.Length == 0) webSite = "(no web site)";
        Console.Write("Manager first name:");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name:");
        string lastName = Console.ReadLine();
        if (lastName.Length == 0 && firstName.Length==0) lastName = "(anonymous)";
        Console.Write("Manager age:");
        string age = Console.ReadLine();
        if (age.Length == 0) age = "(no age)";
        Console.Write("Manager phone:");
        string manPhone = Console.ReadLine();
        if (manPhone.Length == 0) manPhone = "(no number)";
        Console.WriteLine(compName + "\n" + "Address: " + compAddress+
            " \nTel. " + phoneNum + "\nFax: " + faxNumber+
            "\nWeb site: " + webSite + "\nManager: " + firstName +
            " " + lastName + " (age: " + age + ", tel. " + manPhone + ")");



    }
}
