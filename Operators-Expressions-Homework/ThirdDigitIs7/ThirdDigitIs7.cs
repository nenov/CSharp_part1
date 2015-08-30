using System;

class ThirdDigitIs7
{
    static void Main()
    {
        //Write an expression that checks for given integer if its third digit from right-to-left is 7.
        Console.WriteLine("Please enter an integer number:");
        int number = int.Parse(Console.ReadLine());
        number = number % 1000;
        if (number / 100 == 7) Console.WriteLine("True");
        else Console.WriteLine("False");
    }
}
