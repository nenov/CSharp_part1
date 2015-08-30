using System;
using System.Globalization;
class CirclePerimeterAndArea
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area 
        //formatted with 2 digits after the decimal point.
        double radius;
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        Console.WriteLine("Please enter the radius of the circle:");
        radius = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the circle is: {0}", ((Math.PI * radius * 2).ToString("F", CultureInfo.InvariantCulture)));
        Console.WriteLine("The area of the circle is: {0}", ((Math.PI * radius * radius).ToString("F", CultureInfo.InvariantCulture)));
    }
}