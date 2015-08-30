using System;
using System.Numerics;
class CatalanNumbers
    {
        static void Main()
        {
            //Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
            Console.WriteLine("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger nFact = 1;
            BigInteger twoNFact = 1;
            BigInteger nPlusOneFact = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                if (i <= n) nFact *= i;
                twoNFact *= i;
                if (i <= (n + 1)) nPlusOneFact *= i;
            }
            Console.WriteLine((double)twoNFact / (double) ( nPlusOneFact*nFact));
        }
    }