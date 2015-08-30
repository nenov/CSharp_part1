using System;
class QuadraticEquation
{
    static void Main()
    {
        //ite a program that reads the coefficients a, b and c of a 
        //quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots)

        Console.WriteLine("Please enter the coefficient a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the coefficient b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the coefficient c:");
        double c = double.Parse(Console.ReadLine());
        double important = (b * b - 4 * a * c);
        /*When it is greater than Zero, we will get two Real Solutions.
        When it is equal to zero, we will get one Real Solution.
        When it is less than Zero, we will get two Imaginary Solutions.*/
        if (important < 0) Console.WriteLine("no real roots");
        else if (important == 0) Console.WriteLine("x1=x2="+(-b) / (2*a));
        else Console.WriteLine("x1="+ (-b - System.Math.Sqrt(important)) / (2 * a)+"; x2="+(-b + System.Math.Sqrt(important)) / (2 * a));
    }
}