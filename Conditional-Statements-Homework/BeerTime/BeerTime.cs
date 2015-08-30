using System;
class BeerTime
{
    static void Main()
    {
        //A beer time is after 1:00 PM and before 3:00 AM.
        //Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
        //a minute in range [00…59] and AM / PM designator) 
        //and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
        //Note: You may need to learn how to parse dates and times.
        //DateTime a = 
        Console.WriteLine("Please enter time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00...59] and AM / PM designator): ");
        string format = "h:mm tt";
        DateTime result;
        string value = Console.ReadLine();
        try
        {
            result = DateTime.ParseExact(value, format, null);
            DateTime t1 = DateTime.Parse("1:00 PM");
            DateTime t2 = DateTime.Parse("3:00 AM");
            if (result>= t1 || result < t2)
            {
                Console.WriteLine("beer time");
            }
            else Console.WriteLine("non-beer time");
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid time");
        }
       
    }
}