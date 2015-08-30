using System;
class BinaryToDecimalNumber
{
    static void Main()
    {
        //Using loops write a program that converts a binary integer number to its decimal form.
        //The input is entered as string. The output should be a variable of type long.
        //Do not use the built-in .NET functionality.
        Console.WriteLine("Please enter the binary number:");
        string input = Console.ReadLine();
        string[] array = new string[input.Length];
        int index = 0;
        long result = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (input[i] == '1') result = result + (long)(Math.Pow(2, index));
            index++;
        }
        Console.WriteLine(result);
    }
}