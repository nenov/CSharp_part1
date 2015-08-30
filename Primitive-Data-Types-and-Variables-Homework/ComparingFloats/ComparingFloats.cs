using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        double firstNum;
        double secNum;
        Console.WriteLine("Enter first number");
        firstNum = double.Parse( Console.ReadLine());
        Console.WriteLine("Enter second number");
        secNum = double.Parse(Console.ReadLine());
        bool isEqual;
        if (Math.Abs( firstNum - secNum) >= eps) isEqual = false;
        else isEqual = true;
        if (isEqual) Console.WriteLine("There are equal");
        else Console.WriteLine("They are not equal");
    }
}

