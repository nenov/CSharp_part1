using System;

class Rectangles
{
    static void Main()
    {
        //Write an expression that calculates rectangle’s perimeter and area by given width and height.
        Console.WriteLine("Please enter rectangle's width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter rectangle's height:");
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = (2 * width) + (2 * height);
        Console.WriteLine("Rectangle's perimeter is " + perimeter + " and rectangle's area is " + area);




    }
}
