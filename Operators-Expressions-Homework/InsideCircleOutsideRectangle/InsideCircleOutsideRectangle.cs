using System;
class InsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter the X coordinae:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the Y coordinae:");
        double y = double.Parse(Console.ReadLine());
        //R(top=1, left=-1, width=6, height=2).
        if (Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= 1.5 * 1.5)
        {
            if (((x < -1) || (x > 5)) || ((y < -1) || (y > 1))) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        else Console.WriteLine("No");
    }
}
