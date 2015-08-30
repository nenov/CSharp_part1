using System;

class ExchangValues
{
    static void Main()
    {
        int first = 5;
        int second = 10;
        Console.WriteLine("First variable is " + first + " and second one is " + second);
        int exchange;
        exchange = first;
        first = second;
        second = exchange;
        Console.WriteLine("Now the first variable is " + first + " and second one is " + second);

    }
}

