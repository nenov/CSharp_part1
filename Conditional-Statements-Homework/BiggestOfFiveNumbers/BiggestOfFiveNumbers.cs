using System;
class BiggestOfFiveNumbers
    {
        static void Main()
        {
            //Write a program that finds the biggest of five numbers by using only five if statements.
            //why use 5 if statements when you can use only one?
            double[] numbers = new double[5];
            double biggest = double.MinValue;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter number "+(i+1)+" out of 5: ");
                numbers[i] = double.Parse(Console.ReadLine());
                if (numbers[i] > biggest) biggest = numbers[i];
            }
            Console.WriteLine("The biggest number of the these is: " + biggest);
        }
    }