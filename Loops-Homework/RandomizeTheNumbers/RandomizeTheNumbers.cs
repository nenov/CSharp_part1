using System;
class RandomizeTheNumbers
{
    static void Main()
    {
        //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
        Console.WriteLine("Please enter an integer number: ");
        int num = int.Parse(Console.ReadLine());
        string[] array = new string[num];
        Random random = new Random();
        for (int i = 0; i < num; i++)
        {
            array[i] = (i + 1).ToString();
        }
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            // NextDouble returns a random number between 0 and 1.
            int r = i + (int)(random.NextDouble() * (n - i));
            string t = array[r];
            array[r] = array[i];
            array[i] = t;
        }
        foreach (string value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}