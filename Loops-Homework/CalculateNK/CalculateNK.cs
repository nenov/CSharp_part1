using System;
class CalculateNK
{
    static void Main()
    {
        //Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
        //Use only one loop.
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter k: ");
        int k = int.Parse(Console.ReadLine());
        long nFact = 1;
        long kFact = 1;
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            kFact *= i;
        }
        Console.WriteLine(nFact/kFact);
    }
}