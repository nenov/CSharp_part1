using System;
class MinMaxSumAverageNNumbers
{
    static void Main()
    {
        //Write a program that reads from the console a sequence of n integer numbers and returns 
        //the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
        //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
        //The output is like in the examples below.
        Console.WriteLine("Please enter how many number are you going to input: ");
        int num = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        int hold;
        for (int i = 0; i < num; i++)
        {
            hold = int.Parse(Console.ReadLine());
            if (hold > max) max = hold;
            if (hold < min) min = hold;
            sum += hold;
        }
        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:0.00}", ((double)sum / (double)num));
    }
}