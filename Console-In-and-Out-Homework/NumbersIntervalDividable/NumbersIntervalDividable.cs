using System;
class NumbersIntervalDividable
    {
        static void Main()
        {
            //Write a program that reads two positive integer numbers 
            //and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
            Console.WriteLine("Please enter the first positive integer: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second positive integer: ");
            int second = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = first; i <= second; i++)
            {
                if (i % 5 == 0) p++;
            }
            Console.WriteLine("The number of numbers between "+first+ " and " + second + " that the reminder of the division by 5 is 0 is: " + p);
        }
    }