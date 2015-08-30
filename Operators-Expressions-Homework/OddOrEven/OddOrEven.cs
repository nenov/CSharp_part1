using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0) Console.WriteLine("The entered number is an even number");
        else Console.WriteLine("The entered number is an odd number");
    }
}
