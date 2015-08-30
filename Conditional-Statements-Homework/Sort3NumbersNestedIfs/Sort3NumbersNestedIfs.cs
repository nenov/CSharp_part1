using System;
class Sort3NumbersNestedIfs
{
    static void Main()
    {
        //Write a program that enters 3 real numbers and prints them sorted in descending order.
        //Use nested if statements.
        //Note: Don’t use arrays and the built-in sorting functionality.
        Console.WriteLine("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        double third = double.Parse(Console.ReadLine());
        if (first >= second && second >= third) Console.WriteLine("{0} {1} {2}", first, second,third);
        else if (first >= third && third >= second) Console.WriteLine("{0} {1} {2}", first, third, second);
        else if (second >= first && first >= third) Console.WriteLine("{0} {1} {2}", second, first, third);
        else if (second >= third && third >= first) Console.WriteLine("{0} {1} {2}", second, third, first);
        else if (third >= first && first >= second) Console.WriteLine("{0} {1} {2}", third, first, second);
        else Console.WriteLine("{0} {1} {2}", third, second, first);



    }
}