using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNull = null;
        double? doubNull = null;
        Console.WriteLine("The int null vall: " + intNull);
        Console.WriteLine("The double null vall: " + doubNull);
        intNull = 6;
        doubNull = 10;
        Console.WriteLine("The int null vall: " + intNull);
        Console.WriteLine("The double null vall: " + doubNull);
    }
}
