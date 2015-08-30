using System;
using System.Numerics;
class CalculateNK2
    {
        static void Main()
        {
            //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
            //Try to use only two loops.
            Console.WriteLine("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter k: ");
            int k = int.Parse(Console.ReadLine());
            BigInteger nFact = 1;
            BigInteger kFact = 1;
            BigInteger nkFact = 1;
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
                if(i<=(n-k))nkFact*=i;
            }
            for (int i = 1; i <= k; i++)
            {
                kFact *= i;
            }
            Console.WriteLine((double)nFact / ((double)kFact * (double)nkFact));
        }
    }