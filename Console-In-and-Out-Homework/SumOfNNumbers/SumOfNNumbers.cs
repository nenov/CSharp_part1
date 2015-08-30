using System;
class SumOfNNumbers
    {
        static void Main()
        {
            //Write a program that enters a number n and after that enters more n numbers 
            //and calculates and prints their sum. Note: You may need to use a for-loop.
            Console.WriteLine("How many numbers are you going to input: ");
            int count = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("Please enter number "+i+": ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum of the numbers is: " + sum);
        }
    }