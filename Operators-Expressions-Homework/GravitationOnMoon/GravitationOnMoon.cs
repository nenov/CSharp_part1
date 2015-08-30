using System;

class GravitationOnMoon
{
    static void Main()
    {
        double weight;
        Console.WriteLine("Please enter your weight your weight");
        weight = double.Parse(Console.ReadLine());
        Console.WriteLine(0.17* weight);
    }
}
