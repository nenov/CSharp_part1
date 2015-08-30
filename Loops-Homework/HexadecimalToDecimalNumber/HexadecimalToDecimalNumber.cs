﻿using System;
class HexadecimalToDecimalNumber
{
    static void Main()
    {
        //Using loops write a program that converts a hexadecimal integer number to its decimal form.
        //The input is entered as string. The output should be a variable of type long.
        //Do not use the built-in .NET functionality.
        Console.WriteLine("Please enter a hexadecimal integer number:");
        string input = Console.ReadLine();
        long result = 0;
        //3B = 3×161+11×160 = 48+11 = 59
        int index = 0;
        for (int i = input.Length-1; i >= 0; i--)
        {
            switch (input[i])
            {
                case 'A': result = result + 10 * (long)Math.Pow(16, index); break;
                case 'B': result = result + 11 * (long)Math.Pow(16, index); break;
                case 'C': result = result + 12 * (long)Math.Pow(16, index); break;
                case 'D': result = result + 13 * (long)Math.Pow(16, index); break;
                case 'E': result = result + 14 * (long)Math.Pow(16, index); break;
                case 'F': result = result + 15 * (long)Math.Pow(16, index); break;
                default: result = result + Convert.ToInt32(input[i] - '0') * (long)Math.Pow(16, index); 
                    break;
            }
            index++;
        }
        Console.WriteLine(result);
    }
}