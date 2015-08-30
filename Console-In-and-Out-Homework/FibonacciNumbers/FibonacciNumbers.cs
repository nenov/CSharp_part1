using System;
class FibonacciNumbers
{
    static void Main()
    {
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
        //(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
        Console.WriteLine("Enter a positive integer number: ");
        int count = int.Parse(Console.ReadLine());
        int now = 1;
        int prev = 1;
        int prevprev = 0;
        if (count > 0) Console.Write(prevprev);
        if (count > 1) Console.Write(", " + prev);
        if (count > 2)
        {
            for (int i = 0; i < (count - 2); i++)
            {
                Console.Write(", " + now);
                prevprev = prev;
                prev = now;
                now = prev + prevprev;
            }
        }
        Console.WriteLine();
    }
}