using System;
using System.Threading;
class RandomNumbersInGivenRange
{
    static void Main()
    {
        //Write a program that enters 3 integers n, min and max (min != max) 
        //and prints n random numbers in the range [min...max].
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter max: ");
        int max = int.Parse(Console.ReadLine());
        Random r = new Random(); 
        for (int i = 0; i < n; i++)
        {
            Console.Write(r.Next(min, max+1) + " ");
        }
    }
}
