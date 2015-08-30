using System;

class StringsObjects
{
    static void Main()
    {
        string helloVar = "Hello";
        string worldVar = "World";
        object objVar = helloVar + ' ' + worldVar;
        string finalString = objVar.ToString();
        Console.WriteLine(finalString);
    }
}

