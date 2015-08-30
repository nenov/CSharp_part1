using System;

class DivideBy7And5
{
    static void Main()
    {
        //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
        Console.WriteLine("Please enter an integer number:");
        int number = int.Parse(Console.ReadLine());
        bool result = number % 7 == 0 && number % 5 == 0 ? true : false;
        if (number == 0) result = false;
        Console.WriteLine(result);
    }
}
