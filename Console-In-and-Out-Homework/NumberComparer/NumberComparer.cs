using System;
class NumberComparer
{
    static void Main()
    {
        //Write a program that gets two numbers from the console and prints the greater of them.
        //Try to implement this without if statements.
        Console.WriteLine("Please enter first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number:");
        double second = double.Parse(Console.ReadLine());
        Console.Write("The greater number is: {0}\n", (first>second)?first:second);
    }
}