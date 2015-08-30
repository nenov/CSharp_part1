using System;
class Numbers1toN
{
    static void Main()
        {
            //write a program that enters from the console a positive integer n 
            //and prints all the numbers from 1 to n, on a single line, separated by a space.
            Console.WriteLine("Enter a positive integer number: ");
            int number = int.Parse( Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
}