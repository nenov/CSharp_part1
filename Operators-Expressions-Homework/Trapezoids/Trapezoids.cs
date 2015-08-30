using System;
class Trapezoids
{
    static void Main()
    {
        //Write an expression that calculates trapezoid's area by given sides a and b and height h.
        Console.WriteLine("Please enter trapezoid's side A:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter trapezoid's side B:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter trapezoid's height H:");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("The trapezoid's area is :" + ((a+b)/2)*h);
    }
}
