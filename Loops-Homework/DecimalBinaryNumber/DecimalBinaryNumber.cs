using System;
class DecimalBinaryNumber
{
    static void Main()
    {
        //Using loops write a program that converts an integer number to its binary representation.
        //The input is entered as long. The output should be a variable of type string.
        //Do not use the built-in .NET functionality.
        Console.WriteLine("Please enter an integer number:");
        long input = long.Parse(Console.ReadLine());
        string result = "";
        if (input == 0) result = "0";
        else while (input != 0)
            {
                if (input % 2 == 1) result = '1' + result;
                else result = '0' + result;
                input /= 2;
            }
        Console.WriteLine(result);
    }
}