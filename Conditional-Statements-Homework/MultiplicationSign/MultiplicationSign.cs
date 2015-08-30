using System;
class MultiplicationSign
{
    static void Main()
    {
        //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        //Use a sequence of if operators.
        Console.WriteLine("Please enter the first real number: ");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second real number: ");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third real number: ");
        double third = double.Parse(Console.ReadLine());
        if (first == 0 || second == 0 || third == 0) Console.WriteLine("0");
        else
        {
            int sign = 0;
            if (first < 0) sign++;
            if (second < 0) sign++;
            if (third < 0) sign++;
            if (sign % 2 == 0) Console.WriteLine("+");
            else Console.WriteLine("-");
        }
    } 
}