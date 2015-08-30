using System;
using System.Numerics;
class TrailingZeroesN
{
    static void Main()
    {
        //Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
        //Your program should work well for very big numbers, e.g. n=100000.
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        string result = nFact.ToString();
        int count = 0;
        for (int i = result.Length-1; i >= 0; i--)
        {
            if (result[i] == '0') count++;
            else break;
        }
        Console.WriteLine(count);
    }
}