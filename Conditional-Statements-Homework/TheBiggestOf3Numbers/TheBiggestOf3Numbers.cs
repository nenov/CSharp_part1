using System;
class TheBiggestOf3Numbers
{
    static void Main()
    {
        //Write a program that finds the biggest of three numbers.
        double[] numbers = new double[3];
        Console.WriteLine("Enter the first number: ");
        numbers[0] = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        numbers[1] = double.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter the third number: ");
        numbers[2] = double.Parse(Console.ReadLine());
        double biggestEver = numbers[0];
        if (numbers[1] > biggestEver) biggestEver = numbers[1];
        if (numbers[2] > biggestEver) biggestEver = numbers[2];
        Console.WriteLine("The biggest number out of the 3 is: " + biggestEver);
    }
}