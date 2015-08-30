using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Please enter the X coordinae:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the Y coordinae:");
        double y = double.Parse(Console.ReadLine());
        if (Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2) <= 2 * 2) Console.WriteLine(true);
        else Console.WriteLine(false);
    }
}
