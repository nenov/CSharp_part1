using System;
class ExchangeIfGreater
    {
        static void Main()
        {
            //Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
            //As a result print the values a and b, separated by a space.
            Console.WriteLine("Please enter first number: ");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            double second = double.Parse(Console.ReadLine());
            if (first < second) Console.WriteLine(first + " " + second);
            else Console.WriteLine(second + " " + first);
        }
    }