using System;
class Sum5Numbers
    {
        static void Main()
        {
            //Write a program that enters 5 numbers (given in a single line, separated by a space), 
            //calculates and prints their sum.
            string[] numbers = new string[5];
            numbers = Console.ReadLine().Split(' ');
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += double.Parse(numbers[i]);
            }
            Console.WriteLine("The sum of the numbers is: " + sum );
        }
    }