using System;
class MatrixOfNumbers
    {
        static void Main()
        {
            //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
            //and prints a matrix like in the examples below. Use two nested loops
            Console.WriteLine("Please enter a positive integer number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int k = i; k < i+num; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }