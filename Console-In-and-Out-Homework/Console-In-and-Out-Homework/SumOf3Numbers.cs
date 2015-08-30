using System;
class SumOf3Numbers
{
    static void Main()
    {
        //Write a program that reads 3 real numbers from the console and prints their sum.
        Console.WriteLine("Please enter the first real number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second real number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third real number:");
        double third = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the three numebers is: " + (first+second+third));
    }
}

