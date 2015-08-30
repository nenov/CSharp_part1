using System;

class BankAccountData
{
    static void Main()
    {
        /*A bank account has a holder name (first name, middle name and last name), 
         * available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types 
         * and descriptive names.*/

        string firstName = "Celine";
        string middleName = "Damn";
        string lastName = "Dion" ;
        int ammount = 1254251; ;
        string bankName = "DSK";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        long number1 = 6331101999990016;
        long number2 = 6331101999990017;
        long number3 = 6331101999990018;
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Middle Name: " + middleName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Balance: " + ammount);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("Credit Card Number 1: " + number1);
        Console.WriteLine("Credit Card Number 2: " + number2);
        Console.WriteLine("Credit Card Number 3: " + number3);
    }
}

