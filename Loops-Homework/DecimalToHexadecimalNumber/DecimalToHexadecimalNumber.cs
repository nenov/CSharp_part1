using System;
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        //Using loops write a program that converts an integer number to its hexadecimal representation.
        //The input is entered as long. The output should be a variable of type string.
        //Do not use the built-in .NET functionality.
        Console.WriteLine("Please enter an integer number:");
        long input = long.Parse(Console.ReadLine());
        string result = "";
        if (input == 0) result = "0";
        else while (input != 0)
            {
                switch (input%16)
                {
                    case 15: result = 'F' + result; break;
                    case 14: result = 'E' + result; break;
                    case 13: result = 'D' + result; break;
                    case 12: result = 'C' + result; break;
                    case 11: result = 'B' + result; break;
                    case 10: result = 'A' + result; break;
                    default: result = (input%16).ToString() + result;
                        break;
                }
                input /= 16;
            }
        Console.WriteLine(result);
    }
}